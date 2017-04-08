namespace Common_Dialog
{
    partial class Form1
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
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.btnPrintPreviewDialog = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.btnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(396, 22);
            this.btnFontDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(135, 31);
            this.btnFontDialog.TabIndex = 0;
            this.btnFontDialog.Text = "FontDialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 22);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 258);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(396, 65);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(182, 31);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "OpenFileDialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(396, 108);
            this.btnSaveFileDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(182, 31);
            this.btnSaveFileDialog.TabIndex = 3;
            this.btnSaveFileDialog.Text = "SaveFileDialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnPrintPreviewDialog
            // 
            this.btnPrintPreviewDialog.Location = new System.Drawing.Point(396, 151);
            this.btnPrintPreviewDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrintPreviewDialog.Name = "btnPrintPreviewDialog";
            this.btnPrintPreviewDialog.Size = new System.Drawing.Size(235, 31);
            this.btnPrintPreviewDialog.TabIndex = 4;
            this.btnPrintPreviewDialog.Text = "PrintPreviewDialog";
            this.btnPrintPreviewDialog.UseVisualStyleBackColor = true;
            this.btnPrintPreviewDialog.Click += new System.EventHandler(this.btnPrintPreviewDialog_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Location = new System.Drawing.Point(396, 194);
            this.btnPrintDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(182, 31);
            this.btnPrintDialog.TabIndex = 5;
            this.btnPrintDialog.Text = "PrintDialog";
            this.btnPrintDialog.UseVisualStyleBackColor = true;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // btnFolderBrowserDialog
            // 
            this.btnFolderBrowserDialog.Location = new System.Drawing.Point(396, 237);
            this.btnFolderBrowserDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFolderBrowserDialog.Name = "btnFolderBrowserDialog";
            this.btnFolderBrowserDialog.Size = new System.Drawing.Size(235, 31);
            this.btnFolderBrowserDialog.TabIndex = 6;
            this.btnFolderBrowserDialog.Text = "FolderBrowserDialog";
            this.btnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDialog.Click += new System.EventHandler(this.btnFolderBrowserDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 295);
            this.Controls.Add(this.btnFolderBrowserDialog);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnPrintPreviewDialog);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFontDialog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.Button btnPrintPreviewDialog;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button btnFolderBrowserDialog;
    }
}

