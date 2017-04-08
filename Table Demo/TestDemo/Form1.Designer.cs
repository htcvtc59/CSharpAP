namespace TestDemo
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtdapd = new System.Windows.Forms.TextBox();
            this.txtdapC = new System.Windows.Forms.TextBox();
            this.txtdapb = new System.Windows.Forms.TextBox();
            this.txtcauhoi = new System.Windows.Forms.TextBox();
            this.txtdapa = new System.Windows.Forms.TextBox();
            this.txtdapan = new System.Windows.Forms.TextBox();
            this.txtmade = new System.Windows.Forms.TextBox();
            this.txtmacauhoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cAUHOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maCauHoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cauHoi1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dapAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(445, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtdapd
            // 
            this.txtdapd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "DapD", true));
            this.txtdapd.Location = new System.Drawing.Point(107, 425);
            this.txtdapd.Name = "txtdapd";
            this.txtdapd.Size = new System.Drawing.Size(162, 20);
            this.txtdapd.TabIndex = 40;
            // 
            // txtdapC
            // 
            this.txtdapC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "DapC", true));
            this.txtdapC.Location = new System.Drawing.Point(107, 399);
            this.txtdapC.Name = "txtdapC";
            this.txtdapC.Size = new System.Drawing.Size(162, 20);
            this.txtdapC.TabIndex = 39;
            // 
            // txtdapb
            // 
            this.txtdapb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "DapB", true));
            this.txtdapb.Location = new System.Drawing.Point(107, 373);
            this.txtdapb.Name = "txtdapb";
            this.txtdapb.Size = new System.Drawing.Size(162, 20);
            this.txtdapb.TabIndex = 38;
            // 
            // txtcauhoi
            // 
            this.txtcauhoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "CauHoi1", true));
            this.txtcauhoi.Location = new System.Drawing.Point(107, 321);
            this.txtcauhoi.Name = "txtcauhoi";
            this.txtcauhoi.Size = new System.Drawing.Size(162, 20);
            this.txtcauhoi.TabIndex = 37;
            // 
            // txtdapa
            // 
            this.txtdapa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "DapA", true));
            this.txtdapa.Location = new System.Drawing.Point(107, 347);
            this.txtdapa.Name = "txtdapa";
            this.txtdapa.Size = new System.Drawing.Size(162, 20);
            this.txtdapa.TabIndex = 36;
            // 
            // txtdapan
            // 
            this.txtdapan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "DapAn", true));
            this.txtdapan.Location = new System.Drawing.Point(107, 451);
            this.txtdapan.Name = "txtdapan";
            this.txtdapan.Size = new System.Drawing.Size(162, 20);
            this.txtdapan.TabIndex = 35;
            // 
            // txtmade
            // 
            this.txtmade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "MaDe", true));
            this.txtmade.Location = new System.Drawing.Point(107, 295);
            this.txtmade.Name = "txtmade";
            this.txtmade.Size = new System.Drawing.Size(162, 20);
            this.txtmade.TabIndex = 34;
            // 
            // txtmacauhoi
            // 
            this.txtmacauhoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cAUHOIBindingSource, "MaCauHoi", true));
            this.txtmacauhoi.Location = new System.Drawing.Point(108, 269);
            this.txtmacauhoi.Name = "txtmacauhoi";
            this.txtmacauhoi.Size = new System.Drawing.Size(162, 20);
            this.txtmacauhoi.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "DapAn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "DapD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "DapC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "DapB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "DapA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "CauHoi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "MaDe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "MaCauHoi";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(364, 370);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCauHoiDataGridViewTextBoxColumn,
            this.maDeDataGridViewTextBoxColumn,
            this.cauHoi1DataGridViewTextBoxColumn,
            this.dapADataGridViewTextBoxColumn,
            this.dapBDataGridViewTextBoxColumn,
            this.dapCDataGridViewTextBoxColumn,
            this.dapDDataGridViewTextBoxColumn,
            this.dapAnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cAUHOIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 249);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // cAUHOIBindingSource
            // 
            this.cAUHOIBindingSource.DataSource = typeof(TestDemo.CAUHOI);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(607, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(415, 272);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 20);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Search";
            // 
            // maCauHoiDataGridViewTextBoxColumn
            // 
            this.maCauHoiDataGridViewTextBoxColumn.DataPropertyName = "MaCauHoi";
            this.maCauHoiDataGridViewTextBoxColumn.HeaderText = "MaCauHoi";
            this.maCauHoiDataGridViewTextBoxColumn.Name = "maCauHoiDataGridViewTextBoxColumn";
            // 
            // maDeDataGridViewTextBoxColumn
            // 
            this.maDeDataGridViewTextBoxColumn.DataPropertyName = "MaDe";
            this.maDeDataGridViewTextBoxColumn.HeaderText = "MaDe";
            this.maDeDataGridViewTextBoxColumn.Name = "maDeDataGridViewTextBoxColumn";
            // 
            // cauHoi1DataGridViewTextBoxColumn
            // 
            this.cauHoi1DataGridViewTextBoxColumn.DataPropertyName = "CauHoi1";
            this.cauHoi1DataGridViewTextBoxColumn.HeaderText = "CauHoi1";
            this.cauHoi1DataGridViewTextBoxColumn.Name = "cauHoi1DataGridViewTextBoxColumn";
            // 
            // dapADataGridViewTextBoxColumn
            // 
            this.dapADataGridViewTextBoxColumn.DataPropertyName = "DapA";
            this.dapADataGridViewTextBoxColumn.HeaderText = "DapA";
            this.dapADataGridViewTextBoxColumn.Name = "dapADataGridViewTextBoxColumn";
            // 
            // dapBDataGridViewTextBoxColumn
            // 
            this.dapBDataGridViewTextBoxColumn.DataPropertyName = "DapB";
            this.dapBDataGridViewTextBoxColumn.HeaderText = "DapB";
            this.dapBDataGridViewTextBoxColumn.Name = "dapBDataGridViewTextBoxColumn";
            // 
            // dapCDataGridViewTextBoxColumn
            // 
            this.dapCDataGridViewTextBoxColumn.DataPropertyName = "DapC";
            this.dapCDataGridViewTextBoxColumn.HeaderText = "DapC";
            this.dapCDataGridViewTextBoxColumn.Name = "dapCDataGridViewTextBoxColumn";
            // 
            // dapDDataGridViewTextBoxColumn
            // 
            this.dapDDataGridViewTextBoxColumn.DataPropertyName = "DapD";
            this.dapDDataGridViewTextBoxColumn.HeaderText = "DapD";
            this.dapDDataGridViewTextBoxColumn.Name = "dapDDataGridViewTextBoxColumn";
            // 
            // dapAnDataGridViewTextBoxColumn
            // 
            this.dapAnDataGridViewTextBoxColumn.DataPropertyName = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.HeaderText = "DapAn";
            this.dapAnDataGridViewTextBoxColumn.Name = "dapAnDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 483);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtdapd);
            this.Controls.Add(this.txtdapC);
            this.Controls.Add(this.txtdapb);
            this.Controls.Add(this.txtcauhoi);
            this.Controls.Add(this.txtdapa);
            this.Controls.Add(this.txtdapan);
            this.Controls.Add(this.txtmade);
            this.Controls.Add(this.txtmacauhoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtdapd;
        private System.Windows.Forms.TextBox txtdapC;
        private System.Windows.Forms.TextBox txtdapb;
        private System.Windows.Forms.TextBox txtcauhoi;
        private System.Windows.Forms.TextBox txtdapa;
        private System.Windows.Forms.TextBox txtdapan;
        private System.Windows.Forms.TextBox txtmade;
        private System.Windows.Forms.TextBox txtmacauhoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cAUHOIBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCauHoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cauHoi1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dapAnDataGridViewTextBoxColumn;
    }
}

