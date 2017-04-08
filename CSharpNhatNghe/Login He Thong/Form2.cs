using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_He_Thong
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "sa" && txtPass.Text == "sa")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Khong dung ten nguoi dung/mat khau", "Thong bao");
                txtUser.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Chac hkong","tra loi",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) {
                Application.Exit();
            }
        }
    }
}
