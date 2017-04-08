namespace RadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChuThuong = new System.Windows.Forms.RadioButton();
            this.rdoChuInHoa = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ Và Tên";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(135, 19);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(192, 20);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.rdoChuInHoa);
            this.groupBox1.Controls.Add(this.rdoChuThuong);
            this.groupBox1.Location = new System.Drawing.Point(16, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Kiểu Chữ";
            // 
            // rdoChuThuong
            // 
            this.rdoChuThuong.AutoSize = true;
            this.rdoChuThuong.Location = new System.Drawing.Point(34, 20);
            this.rdoChuThuong.Name = "rdoChuThuong";
            this.rdoChuThuong.Size = new System.Drawing.Size(84, 17);
            this.rdoChuThuong.TabIndex = 0;
            this.rdoChuThuong.TabStop = true;
            this.rdoChuThuong.Text = "Chữ Thường";
            this.rdoChuThuong.UseVisualStyleBackColor = true;
            // 
            // rdoChuInHoa
            // 
            this.rdoChuInHoa.AutoSize = true;
            this.rdoChuInHoa.Location = new System.Drawing.Point(34, 60);
            this.rdoChuInHoa.Name = "rdoChuInHoa";
            this.rdoChuInHoa.Size = new System.Drawing.Size(88, 17);
            this.rdoChuInHoa.TabIndex = 1;
            this.rdoChuInHoa.TabStop = true;
            this.rdoChuInHoa.Text = "CHỮ IN HOA";
            this.rdoChuInHoa.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(16, 166);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 5;
            this.btnKetQua.Text = "Kết Quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(135, 168);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(192, 20);
            this.txtKQ.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(280, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 48);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 204);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton rdoChuInHoa;
        private System.Windows.Forms.RadioButton rdoChuThuong;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

