namespace Stenographer.Presentation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpImageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.lblSelectImage = new System.Windows.Forms.Label();
            this.pcbPreview = new System.Windows.Forms.PictureBox();
            this.txtSelectedImage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.rdbEncrypt = new System.Windows.Forms.RadioButton();
            this.rdbDecrypt = new System.Windows.Forms.RadioButton();
            this.lblImageSizeLabel = new System.Windows.Forms.Label();
            this.lblSpaceLable = new System.Windows.Forms.Label();
            this.tkbPrecision = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.tlpEmbedderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblFileSizeLabel = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.rdbFile = new System.Windows.Forms.RadioButton();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rdbMessage = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCharsLeft = new System.Windows.Forms.Label();
            this.lblCharsLeftLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grbEncryption = new System.Windows.Forms.GroupBox();
            this.tlpImageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPrecision)).BeginInit();
            this.tlpEmbedderLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpImageLayout
            // 
            this.tlpImageLayout.ColumnCount = 4;
            this.tlpImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpImageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpImageLayout.Controls.Add(this.btnSelectImg, 2, 0);
            this.tlpImageLayout.Controls.Add(this.lblSelectImage, 0, 0);
            this.tlpImageLayout.Controls.Add(this.pcbPreview, 3, 0);
            this.tlpImageLayout.Controls.Add(this.txtSelectedImage, 1, 0);
            this.tlpImageLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpImageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImageLayout.Location = new System.Drawing.Point(23, 23);
            this.tlpImageLayout.Name = "tlpImageLayout";
            this.tlpImageLayout.RowCount = 2;
            this.tlpImageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpImageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpImageLayout.Size = new System.Drawing.Size(854, 85);
            this.tlpImageLayout.TabIndex = 0;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectImg.BackColor = System.Drawing.Color.Silver;
            this.btnSelectImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImg.Location = new System.Drawing.Point(529, 4);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(98, 33);
            this.btnSelectImg.TabIndex = 0;
            this.btnSelectImg.Text = "Select Image";
            this.btnSelectImg.UseVisualStyleBackColor = false;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // lblSelectImage
            // 
            this.lblSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectImage.AutoSize = true;
            this.lblSelectImage.Location = new System.Drawing.Point(3, 14);
            this.lblSelectImage.Name = "lblSelectImage";
            this.lblSelectImage.Size = new System.Drawing.Size(72, 13);
            this.lblSelectImage.TabIndex = 2;
            this.lblSelectImage.Text = "Select Image:";
            // 
            // pcbPreview
            // 
            this.pcbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPreview.Location = new System.Drawing.Point(633, 3);
            this.pcbPreview.Name = "pcbPreview";
            this.pcbPreview.Size = new System.Drawing.Size(218, 36);
            this.pcbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbPreview.TabIndex = 3;
            this.pcbPreview.TabStop = false;
            // 
            // txtSelectedImage
            // 
            this.txtSelectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedImage.Location = new System.Drawing.Point(81, 11);
            this.txtSelectedImage.Name = "txtSelectedImage";
            this.txtSelectedImage.ReadOnly = true;
            this.txtSelectedImage.Size = new System.Drawing.Size(442, 20);
            this.txtSelectedImage.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tlpImageLayout.SetColumnSpan(this.tableLayoutPanel1, 4);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblSpace, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblImageSize, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbEncrypt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbDecrypt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblImageSizeLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSpaceLable, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tkbPrecision, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 37);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblSpace
            // 
            this.lblSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(421, 12);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(1, 13);
            this.lblSpace.TabIndex = 6;
            // 
            // lblImageSize
            // 
            this.lblImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(322, 12);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(1, 13);
            this.lblImageSize.TabIndex = 4;
            // 
            // rdbEncrypt
            // 
            this.rdbEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbEncrypt.AutoSize = true;
            this.rdbEncrypt.Checked = true;
            this.rdbEncrypt.Location = new System.Drawing.Point(3, 10);
            this.rdbEncrypt.Name = "rdbEncrypt";
            this.rdbEncrypt.Size = new System.Drawing.Size(103, 17);
            this.rdbEncrypt.TabIndex = 1;
            this.rdbEncrypt.TabStop = true;
            this.rdbEncrypt.Text = "Encrypt in image";
            this.rdbEncrypt.UseVisualStyleBackColor = true;
            // 
            // rdbDecrypt
            // 
            this.rdbDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbDecrypt.AutoSize = true;
            this.rdbDecrypt.Location = new System.Drawing.Point(112, 10);
            this.rdbDecrypt.Name = "rdbDecrypt";
            this.rdbDecrypt.Size = new System.Drawing.Size(116, 17);
            this.rdbDecrypt.TabIndex = 2;
            this.rdbDecrypt.Text = "Decrypt from image";
            this.rdbDecrypt.UseVisualStyleBackColor = true;
            this.rdbDecrypt.CheckedChanged += new System.EventHandler(this.rdbDecrypt_CheckedChanged);
            // 
            // lblImageSizeLabel
            // 
            this.lblImageSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageSizeLabel.AutoSize = true;
            this.lblImageSizeLabel.Location = new System.Drawing.Point(254, 12);
            this.lblImageSizeLabel.Name = "lblImageSizeLabel";
            this.lblImageSizeLabel.Size = new System.Drawing.Size(62, 13);
            this.lblImageSizeLabel.TabIndex = 3;
            this.lblImageSizeLabel.Text = "Image Size:";
            this.lblImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpaceLable
            // 
            this.lblSpaceLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpaceLable.AutoSize = true;
            this.lblSpaceLable.Location = new System.Drawing.Point(328, 12);
            this.lblSpaceLable.Name = "lblSpaceLable";
            this.lblSpaceLable.Size = new System.Drawing.Size(87, 13);
            this.lblSpaceLable.TabIndex = 5;
            this.lblSpaceLable.Text = "Space Available:";
            // 
            // tkbPrecision
            // 
            this.tkbPrecision.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tkbPrecision.LargeChange = 2;
            this.tkbPrecision.Location = new System.Drawing.Point(694, 3);
            this.tkbPrecision.Maximum = 8;
            this.tkbPrecision.Minimum = 1;
            this.tkbPrecision.Name = "tkbPrecision";
            this.tkbPrecision.Size = new System.Drawing.Size(151, 31);
            this.tkbPrecision.TabIndex = 7;
            this.tkbPrecision.Value = 1;
            this.tkbPrecision.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precision Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.BackColor = System.Drawing.Color.Silver;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Location = new System.Drawing.Point(779, 465);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(98, 29);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tlpEmbedderLayout
            // 
            this.tlpEmbedderLayout.ColumnCount = 3;
            this.tlpEmbedderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmbedderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmbedderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEmbedderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmbedderLayout.Controls.Add(this.lblFileSizeLabel, 0, 4);
            this.tlpEmbedderLayout.Controls.Add(this.lblFileSize, 0, 4);
            this.tlpEmbedderLayout.Controls.Add(this.rdbFile, 1, 0);
            this.tlpEmbedderLayout.Controls.Add(this.btnSelectFile, 2, 3);
            this.tlpEmbedderLayout.Controls.Add(this.lblSelectFile, 0, 3);
            this.tlpEmbedderLayout.Controls.Add(this.txtFile, 1, 3);
            this.tlpEmbedderLayout.Controls.Add(this.lblMessage, 0, 1);
            this.tlpEmbedderLayout.Controls.Add(this.txtMessage, 0, 2);
            this.tlpEmbedderLayout.Controls.Add(this.rdbMessage, 0, 0);
            this.tlpEmbedderLayout.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tlpEmbedderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmbedderLayout.Location = new System.Drawing.Point(3, 16);
            this.tlpEmbedderLayout.Name = "tlpEmbedderLayout";
            this.tlpEmbedderLayout.RowCount = 5;
            this.tlpEmbedderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmbedderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmbedderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmbedderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEmbedderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmbedderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmbedderLayout.Size = new System.Drawing.Size(848, 326);
            this.tlpEmbedderLayout.TabIndex = 5;
            // 
            // lblFileSizeLabel
            // 
            this.lblFileSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileSizeLabel.AutoSize = true;
            this.lblFileSizeLabel.Location = new System.Drawing.Point(3, 309);
            this.lblFileSizeLabel.Name = "lblFileSizeLabel";
            this.lblFileSizeLabel.Size = new System.Drawing.Size(107, 13);
            this.lblFileSizeLabel.TabIndex = 10;
            this.lblFileSizeLabel.Text = "File Size: ";
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(116, 309);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(625, 13);
            this.lblFileSize.TabIndex = 9;
            // 
            // rdbFile
            // 
            this.rdbFile.AutoSize = true;
            this.rdbFile.Location = new System.Drawing.Point(116, 3);
            this.rdbFile.Name = "rdbFile";
            this.rdbFile.Size = new System.Drawing.Size(97, 17);
            this.rdbFile.TabIndex = 7;
            this.rdbFile.Text = "Select from File";
            this.rdbFile.UseVisualStyleBackColor = true;
            this.rdbFile.CheckedChanged += new System.EventHandler(this.rdbFile_CheckedChanged);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.BackColor = System.Drawing.Color.Silver;
            this.btnSelectFile.Enabled = false;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Location = new System.Drawing.Point(747, 270);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(98, 33);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(3, 280);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(107, 13);
            this.lblSelectFile.TabIndex = 2;
            this.lblSelectFile.Text = "Select File:";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.BackColor = System.Drawing.Color.White;
            this.txtFile.Location = new System.Drawing.Point(116, 276);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(625, 20);
            this.txtFile.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(3, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(107, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Embedded Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.AliceBlue;
            this.tlpEmbedderLayout.SetColumnSpan(this.txtMessage, 3);
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.Location = new System.Drawing.Point(3, 46);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(842, 218);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // rdbMessage
            // 
            this.rdbMessage.AutoSize = true;
            this.rdbMessage.Checked = true;
            this.rdbMessage.Location = new System.Drawing.Point(3, 3);
            this.rdbMessage.Name = "rdbMessage";
            this.rdbMessage.Size = new System.Drawing.Size(68, 17);
            this.rdbMessage.TabIndex = 6;
            this.rdbMessage.TabStop = true;
            this.rdbMessage.Text = "Message";
            this.rdbMessage.UseVisualStyleBackColor = true;
            this.rdbMessage.CheckedChanged += new System.EventHandler(this.rdbMessage_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblCharsLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCharsLeftLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(116, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(625, 14);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblCharsLeft
            // 
            this.lblCharsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharsLeft.AutoSize = true;
            this.lblCharsLeft.Location = new System.Drawing.Point(126, 0);
            this.lblCharsLeft.Name = "lblCharsLeft";
            this.lblCharsLeft.Size = new System.Drawing.Size(496, 13);
            this.lblCharsLeft.TabIndex = 9;
            // 
            // lblCharsLeftLabel
            // 
            this.lblCharsLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharsLeftLabel.AutoSize = true;
            this.lblCharsLeftLabel.Location = new System.Drawing.Point(3, 0);
            this.lblCharsLeftLabel.Name = "lblCharsLeftLabel";
            this.lblCharsLeftLabel.Size = new System.Drawing.Size(117, 13);
            this.lblCharsLeftLabel.TabIndex = 8;
            this.lblCharsLeftLabel.Text = "Characters Remaining: ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.grbEncryption, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tlpImageLayout, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAction, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(900, 517);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // grbEncryption
            // 
            this.grbEncryption.Controls.Add(this.tlpEmbedderLayout);
            this.grbEncryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbEncryption.Location = new System.Drawing.Point(23, 114);
            this.grbEncryption.Name = "grbEncryption";
            this.grbEncryption.Size = new System.Drawing.Size(854, 345);
            this.grbEncryption.TabIndex = 7;
            this.grbEncryption.TabStop = false;
            this.grbEncryption.Text = "Encrypted Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 517);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tlpImageLayout.ResumeLayout(false);
            this.tlpImageLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPrecision)).EndInit();
            this.tlpEmbedderLayout.ResumeLayout(false);
            this.tlpEmbedderLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grbEncryption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpImageLayout;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.TextBox txtSelectedImage;
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.PictureBox pcbPreview;
        private System.Windows.Forms.RadioButton rdbEncrypt;
        private System.Windows.Forms.RadioButton rdbDecrypt;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TableLayoutPanel tlpEmbedderLayout;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.RadioButton rdbFile;
        private System.Windows.Forms.RadioButton rdbMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grbEncryption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label lblImageSizeLabel;
        private System.Windows.Forms.Label lblSpaceLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCharsLeft;
        private System.Windows.Forms.Label lblCharsLeftLabel;
        private System.Windows.Forms.TrackBar tkbPrecision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileSizeLabel;
        private System.Windows.Forms.Label lblFileSize;
    }
}