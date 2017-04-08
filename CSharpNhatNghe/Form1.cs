using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtDangNhap.Text;
            thongbao += "\nMật khẩu là: ";
            thongbao += this.txtMatKhau.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn ghi nhớ mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.cbGhiNho.Checked = true;
            }else
                this.cbGhiNho.Checked = false;
            if (this.cbGhiNho.Checked == true)
            {
                thongbao += "\n\rBạn có ghi nhớ.";
            }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtDangNhap.Clear();
            this.txtMatKhau.ResetText();
            txtDangNhap.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
