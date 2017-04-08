namespace ASMAP
{
    partial class FrmQuestion
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
            this.cbbAllMaDe = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaMaDe = new System.Windows.Forms.Button();
            this.txtTenDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddMaDe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddMaDe = new System.Windows.Forms.Button();
            this.dgvQues = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDapAn = new System.Windows.Forms.TextBox();
            this.txtDapD = new System.Windows.Forms.TextBox();
            this.txtDapC = new System.Windows.Forms.TextBox();
            this.txtDapB = new System.Windows.Forms.TextBox();
            this.txtDapA = new System.Windows.Forms.TextBox();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQues)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbAllMaDe
            // 
            this.cbbAllMaDe.FormattingEnabled = true;
            this.cbbAllMaDe.Location = new System.Drawing.Point(7, 36);
            this.cbbAllMaDe.Name = "cbbAllMaDe";
            this.cbbAllMaDe.Size = new System.Drawing.Size(100, 21);
            this.cbbAllMaDe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaMaDe);
            this.groupBox1.Controls.Add(this.txtTenDe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbAllMaDe);
            this.groupBox1.Controls.Add(this.txtAddMaDe);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAddMaDe);
            this.groupBox1.Location = new System.Drawing.Point(9, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Mã Đề";
            // 
            // btnXoaMaDe
            // 
            this.btnXoaMaDe.Location = new System.Drawing.Point(113, 34);
            this.btnXoaMaDe.Name = "btnXoaMaDe";
            this.btnXoaMaDe.Size = new System.Drawing.Size(75, 23);
            this.btnXoaMaDe.TabIndex = 7;
            this.btnXoaMaDe.Text = "Xóa Mã Đề";
            this.btnXoaMaDe.UseVisualStyleBackColor = true;
            this.btnXoaMaDe.Click += new System.EventHandler(this.btnXoaMaDe_Click);
            // 
            // txtTenDe
            // 
            this.txtTenDe.Location = new System.Drawing.Point(7, 120);
            this.txtTenDe.Name = "txtTenDe";
            this.txtTenDe.Size = new System.Drawing.Size(100, 20);
            this.txtTenDe.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tất Cả Mã Đề";
            // 
            // txtAddMaDe
            // 
            this.txtAddMaDe.Location = new System.Drawing.Point(7, 81);
            this.txtAddMaDe.Name = "txtAddMaDe";
            this.txtAddMaDe.Size = new System.Drawing.Size(100, 20);
            this.txtAddMaDe.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã Đề";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên Đề";
            // 
            // btnAddMaDe
            // 
            this.btnAddMaDe.Location = new System.Drawing.Point(113, 118);
            this.btnAddMaDe.Name = "btnAddMaDe";
            this.btnAddMaDe.Size = new System.Drawing.Size(92, 23);
            this.btnAddMaDe.TabIndex = 1;
            this.btnAddMaDe.Text = "Thêm Mã Đề";
            this.btnAddMaDe.UseVisualStyleBackColor = true;
            this.btnAddMaDe.Click += new System.EventHandler(this.btnAddMaDe_Click);
            // 
            // dgvQues
            // 
            this.dgvQues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQues.Location = new System.Drawing.Point(6, 19);
            this.dgvQues.Name = "dgvQues";
            this.dgvQues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQues.Size = new System.Drawing.Size(840, 290);
            this.dgvQues.TabIndex = 2;
            this.dgvQues.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvQues_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtDapAn);
            this.groupBox2.Controls.Add(this.txtDapD);
            this.groupBox2.Controls.Add(this.txtDapC);
            this.groupBox2.Controls.Add(this.txtDapB);
            this.groupBox2.Controls.Add(this.txtDapA);
            this.groupBox2.Controls.Add(this.txtCauHoi);
            this.groupBox2.Controls.Add(this.txtMaDe);
            this.groupBox2.Controls.Add(this.txtMaCauHoi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvQues);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 485);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý đề và câu hỏi";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(756, 332);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(488, 321);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(318, 323);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 20);
            this.txtSearch.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(756, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(756, 443);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(756, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(565, 449);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Size = new System.Drawing.Size(139, 20);
            this.txtDapAn.TabIndex = 18;
            // 
            // txtDapD
            // 
            this.txtDapD.Location = new System.Drawing.Point(565, 417);
            this.txtDapD.Name = "txtDapD";
            this.txtDapD.Size = new System.Drawing.Size(139, 20);
            this.txtDapD.TabIndex = 17;
            // 
            // txtDapC
            // 
            this.txtDapC.Location = new System.Drawing.Point(565, 387);
            this.txtDapC.Name = "txtDapC";
            this.txtDapC.Size = new System.Drawing.Size(139, 20);
            this.txtDapC.TabIndex = 16;
            // 
            // txtDapB
            // 
            this.txtDapB.Location = new System.Drawing.Point(565, 359);
            this.txtDapB.Name = "txtDapB";
            this.txtDapB.Size = new System.Drawing.Size(139, 20);
            this.txtDapB.TabIndex = 15;
            // 
            // txtDapA
            // 
            this.txtDapA.Location = new System.Drawing.Point(318, 457);
            this.txtDapA.Name = "txtDapA";
            this.txtDapA.Size = new System.Drawing.Size(139, 20);
            this.txtDapA.TabIndex = 14;
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Location = new System.Drawing.Point(318, 428);
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(139, 20);
            this.txtCauHoi.TabIndex = 13;
            // 
            // txtMaDe
            // 
            this.txtMaDe.Location = new System.Drawing.Point(318, 394);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(139, 20);
            this.txtMaDe.TabIndex = 12;
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(318, 359);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(139, 20);
            this.txtMaCauHoi.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "DapAn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "DapD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DapC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DapB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DapA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CauHoi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MaDe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MaCauHoi";
            // 
            // FrmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(866, 494);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuestion_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQues)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbAllMaDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddMaDe;
        private System.Windows.Forms.Button btnAddMaDe;
        private System.Windows.Forms.DataGridView dgvQues;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDapAn;
        private System.Windows.Forms.TextBox txtDapD;
        private System.Windows.Forms.TextBox txtDapC;
        private System.Windows.Forms.TextBox txtDapB;
        private System.Windows.Forms.TextBox txtDapA;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.TextBox txtMaDe;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoaMaDe;
    }
}