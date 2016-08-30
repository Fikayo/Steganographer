using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stenographer.Application;

namespace Stenographer.Presentation
{
    public partial class MainForm : Form
    {
        private static readonly Color EnabledColor = Color.AliceBlue;
        private static readonly Color DiseabledColor = Color.Silver;

        private Bitmap image;
        private ImageProperties properties;
        private long inputLength;
        private FileType encryptionFileType;

        public MainForm()
        {
            InitializeComponent();
            this.encryptionFileType = FileType.Str;
        }

        private void EncryptImage()
        {
            ResultForm resultForm = null;
            var isMessage = this.rdbMessage.Checked;
            Encryptable encryptable = null;
            if (isMessage)
            {
                var message = this.txtMessage.Text;
                if (string.IsNullOrEmpty(message))
                {
                    Util.Error("Encryption message cannot be empty");
                    return;
                }

                encryptable = new MessageEncryption(message);
            }
            else
            {
                var filename = this.txtFile.Text;
                encryptable = this.GetFileEncryptable(filename);
            }

            if (encryptable != null)
            {
                try
                {
                    encryptable.Precision = this.tkbPrecision.Value;
                    Embedder embedder = new Embedder();
                    EncryptResult result = null;

                    PleaseWaitDialog.Show(() =>
                    {
                        result = embedder.Embed(this.image, encryptable);
                    }, "Encrypting " + (isMessage ? "message" : "file") + " in image...");

                    if (result != null)
                    {
                        resultForm = new ResultForm(result);
                        resultForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    PleaseWaitDialog.Cancel();
                }
            }
        }

        private Encryptable GetFileEncryptable(string filename)
        {
            Encryptable encryptable = null;
            if (string.IsNullOrEmpty(filename))
            {
                Util.Error("Please select a file to be encrypted");
                return null;
            }

            if (!File.Exists(filename))
            {
                Util.Error("File does not exist. Please select another file");
                return null;
            }

            var space = this.properties.SpaceAvailableInBytes - this.inputLength;
            if (space <= 8)
            {
                var result = MessageBox.Show(
                    "There is insufficient space to store the the entire file." +
                    "\nParts of the file may be not be encrypted which may render the file unreadable when decrypted (this may not be an issue for audio and video files)" +
                    "\nWould you like to proceed anyway?",
                      "Insufficient space  ",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Exclamation,
                      MessageBoxDefaultButton.Button2);

                if (result != DialogResult.Yes)
                {
                    return null;
                }
            }

            /* Get file obj */
            switch (this.encryptionFileType)
            {
                case FileType.Img:
                    {
                        encryptable = new ImageEncryption(filename, System.IO.Path.GetExtension(filename));
                        break;
                    }

                case FileType.Fle:
                    {
                        encryptable = new FileEncryption(filename);
                        break;
                    }

                default:
                    break;
            }

            return encryptable;
        }

        private void DecryptImage()
        {
            try
            {
                Decrypter decrypter = new Decrypter();
                EncryptResult result = null;

                PleaseWaitDialog.Show(() =>
                {
                    result = decrypter.Decrypt(this.image);
                }, "Decrypting message from image...");

                if (result != null)
                {
                    ResultForm resultForm = new ResultForm(result);
                    resultForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PleaseWaitDialog.Cancel();
            }
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|All files|*.*",
                AddExtension = true,
                Title = "Please select an image"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = dialog.FileName;
                    bool success = true;
                    try
                    {
                        this.image = (Bitmap)Bitmap.FromFile(filename);
                        this.properties = new ImageProperties(this.image);
                        this.pcbPreview.Image = this.image;
                    }
                    catch (Exception ex)
                    {
                        success = false;
                        MessageBox.Show("The following error occurred: " + ex.Message + "\r\nPlease make sure the selected file is an image and try again.");
                        this.txtSelectedImage.Text = string.Empty;
                    }

                    if (success)
                    {
                        this.txtSelectedImage.Text = filename;
                        this.lblImageSize.Text = new FileInfo(filename).Length.ToFileSize();
                        this.lblSpace.Text = this.properties.SpaceAvailableInBytes.ToFileSize();
                        this.inputLength = this.properties.SpaceAvailableInBytes;
                        this.lblCharsLeft.Text = this.inputLength.ToString();
                    }
                }
            }
        }

        private void rdbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.grbEncryption.Enabled = !this.rdbDecrypt.Checked;
        }

        private void rdbMessage_CheckedChanged(object sender, EventArgs e)
        {
            var enableOther = !this.rdbMessage.Checked;
            this.btnSelectFile.Enabled = enableOther;
            this.btnSelectFile.BackColor = enableOther ? MainForm.EnabledColor : MainForm.DiseabledColor;
        }

        private void rdbFile_CheckedChanged(object sender, EventArgs e)
        {
            var enableOther = !this.rdbFile.Checked;
            this.txtMessage.Enabled = enableOther;
            this.txtMessage.BackColor = enableOther ? MainForm.EnabledColor : MainForm.DiseabledColor;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSelectedImage.Text))
            {
                Util.Error("Please select an image.");
                return;
            }

            var encrypt = this.rdbEncrypt.Checked;
            if (encrypt)
            {
                this.EncryptImage();
            }
            else
            {
                this. DecryptImage();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog()
           {
               Multiselect = false,
               Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png|Audio|*.mp3|Videos|*.mp4;*.flv|Pdf|*.pdf|All files|*.*",
               AddExtension = true,
               Title = "Please select a file"
           })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var filename = dialog.FileName;
                    this.txtFile.Text = filename;
                    encryptionFileType = FileType.Fle;
                    if (dialog.FilterIndex == 0)
                    {
                        encryptionFileType = FileType.Img;
                    }

                    this.inputLength = new FileInfo(filename).Length;
                    this.lblFileSize.Text = this.inputLength.ToFileSize();
                }
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (this.inputLength > 0)
            {
                var max = this.properties.SpaceAvailableInBytes / 8;
                var text = this.txtMessage.Text;
                var charsLeft = max - text.Length;
                if (charsLeft == this.inputLength)
                {
                    return;
                }

                this.inputLength = charsLeft;
                if (charsLeft < 0)
                {
                    this.inputLength = 0;
                    this.txtMessage.Text = text.Substring(0, (int)max);
                }

                this.lblCharsLeft.Text = this.inputLength.ToString();
            }
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            var isInput = char.IsLetterOrDigit(e.KeyChar);
            if (isInput)
            {
                this.inputLength--;
                if (this.inputLength < 0)
                {
                    e.Handled = true;
                    this.inputLength = 0;
                }
            }

            if ((char)Keys.Back == e.KeyChar)
            {
                this.inputLength++;
                var max = this.properties.SpaceAvailableInBytes / 8;
                if (this.inputLength == max)
                {
                    this.inputLength = max;
                }
            }

            this.lblCharsLeft.Text = this.inputLength.ToString();
        }
    }
}
