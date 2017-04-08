using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string hoten = txtHoVaTen.Text.Trim();
            if (rdoChuThuong.Checked == true) {
                txtKQ.Text = hoten.ToLower();
            }
            if (rdoChuInHoa.Checked == true) {
                txtKQ.Text = hoten.ToUpper();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Clear();
            txtKQ.ResetText();
            rdoChuThuong.Checked = true;
            txtHoVaTen.Focus();
        }
    }
}
