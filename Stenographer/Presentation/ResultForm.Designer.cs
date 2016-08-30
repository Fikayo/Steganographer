namespace Stenographer.Presentation
{
    partial class ResultForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSaveLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSelectImage = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.pnlEmbeddedObj = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpSaveLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tlpSaveLayout, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlEmbeddedObj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblInfo, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpSaveLayout
            // 
            this.tlpSaveLayout.ColumnCount = 4;
            this.tlpSaveLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSaveLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSaveLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSaveLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpSaveLayout.Controls.Add(this.lblSelectImage, 0, 0);
            this.tlpSaveLayout.Controls.Add(this.txtFilePath, 1, 0);
            this.tlpSaveLayout.Controls.Add(this.lblExt, 2, 0);
            this.tlpSaveLayout.Controls.Add(this.btnSelFolder, 3, 0);
            this.tlpSaveLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSaveLayout.Location = new System.Drawing.Point(23, 23);
            this.tlpSaveLayout.Name = "tlpSaveLayout";
            this.tlpSaveLayout.RowCount = 1;
            this.tlpSaveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSaveLayout.Size = new System.Drawing.Size(610, 79);
            this.tlpSaveLayout.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(535, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 33);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelectImage
            // 
            this.lblSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectImage.AutoSize = true;
            this.lblSelectImage.Location = new System.Drawing.Point(3, 33);
            this.lblSelectImage.Name = "lblSelectImage";
            this.lblSelectImage.Size = new System.Drawing.Size(81, 13);
            this.lblSelectImage.TabIndex = 2;
            this.lblSelectImage.Text = "Select File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(90, 29);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(407, 20);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = "C:\\";
            // 
            // lblExt
            // 
            this.lblExt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(503, 33);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(1, 13);
            this.lblExt.TabIndex = 3;
            // 
            // pnlEmbeddedObj
            // 
            this.pnlEmbeddedObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmbeddedObj.Location = new System.Drawing.Point(23, 128);
            this.pnlEmbeddedObj.Name = "pnlEmbeddedObj";
            this.pnlEmbeddedObj.Size = new System.Drawing.Size(610, 255);
            this.pnlEmbeddedObj.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(23, 108);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(610, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Embedded Object";
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelFolder.BackColor = System.Drawing.Color.Silver;
            this.btnSelFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelFolder.Location = new System.Drawing.Point(509, 23);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(98, 33);
            this.btnSelFolder.TabIndex = 4;
            this.btnSelFolder.Text = "Select Folder";
            this.btnSelFolder.UseVisualStyleBackColor = false;
            this.btnSelFolder.Click += new System.EventHandler(this.btnSelFolder_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpSaveLayout.ResumeLayout(false);
            this.tlpSaveLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpSaveLayout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Panel pnlEmbeddedObj;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.Button btnSelFolder;
    }
}