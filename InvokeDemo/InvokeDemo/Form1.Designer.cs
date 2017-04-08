namespace InvokeDemo
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
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.pgrOperation = new System.Windows.Forms.ProgressBar();
            this.cmdGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumber
            // 
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.Location = new System.Drawing.Point(12, 12);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.Size = new System.Drawing.Size(210, 160);
            this.lstNumber.TabIndex = 0;
            // 
            // pgrOperation
            // 
            this.pgrOperation.Location = new System.Drawing.Point(12, 178);
            this.pgrOperation.Name = "pgrOperation";
            this.pgrOperation.Size = new System.Drawing.Size(210, 21);
            this.pgrOperation.TabIndex = 1;
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.Location = new System.Drawing.Point(144, 205);
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(78, 31);
            this.cmdGenerate.TabIndex = 2;
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.UseVisualStyleBackColor = true;
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 246);
            this.Controls.Add(this.cmdGenerate);
            this.Controls.Add(this.pgrOperation);
            this.Controls.Add(this.lstNumber);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvokeDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumber;
        private System.Windows.Forms.ProgressBar pgrOperation;
        private System.Windows.Forms.Button cmdGenerate;
    }
}

