using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Stenographer.Application;
using Stenographer.Properties;

namespace Stenographer.Presentation
{
    public partial class ResultForm : Form
    {
        private EncryptResult result;

        private ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(EncryptResult result)
            : this()
        {
            Init(result);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var filename = this.txtFilePath.Text;
            if (string.IsNullOrEmpty(filename) || string.IsNullOrEmpty(System.IO.Path.GetFileName(filename)))
            {
                MessageBox.Show("Please enter a valid file name");
                return;
            }

            filename = System.IO.Path.ChangeExtension(filename, this.result.Header.FileExt);

            PleaseWaitDialog.Show(() =>
            {
                this.result.Save(filename);
            }, "Saving output");


            MessageBox.Show("Saved file '" + filename + "'");
            this.Close();
        }

        private void Init(EncryptResult result)
        {
            string ext = string.Empty;
            switch (result.Header.FileType)
            {
                case FileType.Str:
                    {
                        var txtBox = new TextBox();
                        txtBox.Text = Util.GetString(result.Bytes);
                        txtBox.Multiline = true;
                        txtBox.Dock = DockStyle.Fill;
                        ext = "txt";

                        this.pnlEmbeddedObj.Controls.Add(txtBox);
                        break;
                    }

                case FileType.Img:
                case FileType.Fle:
                    {
                        var picBox = new PictureBox();
                        picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                        Image image;
                        if (result.Header.FileType == FileType.Img)
                        {
                            image = Util.ByteArrayToObject(result.Bytes) as Image;
                        }
                        else
                        {
                            image = Resources.ResourceManager.GetObject("fileImage") as Image;
                        }

                        picBox.Image = image;
                        picBox.Dock = DockStyle.Fill;
                        ext = result.Header.FileExt.ToLowerInvariant();
                        this.pnlEmbeddedObj.Controls.Add(picBox);
                        break;
                    }

                default:
                    break;

            }

            this.result = result;
            this.lblExt.Text = !string.IsNullOrEmpty(ext) ? "." + ext : string.Empty;
        }

        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog()
            {
                Description = "Select Destination folder",
                ShowNewFolderButton = true,
            })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtFilePath.Text = folderDialog.SelectedPath + "\\";
                }
            }

        }
    }
}
