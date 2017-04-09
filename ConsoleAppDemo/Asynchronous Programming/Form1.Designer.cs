namespace Asynchronous_Programming
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
            this.btnBig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(30, 43);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(99, 57);
            this.btnBig.TabIndex = 0;
            this.btnBig.Text = "Big Task";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(82, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(150, 43);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(99, 57);
            this.btnMes.TabIndex = 2;
            this.btnMes.Text = "Message";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMes;
    }
}

