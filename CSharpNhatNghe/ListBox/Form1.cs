using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstWeb.Items.Add("Tuổi trẻ");
            lstWeb.Items.Add("Thanh niên");
            lstWeb.Items.Add("VNExpress");
            lstWeb.Items.Add("Dân trí");
            lstWeb.Items.Add("Công an");
            lstWeb.SelectedItem = "Tuổi trẻ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.ResetText();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "Bạn đã chọn website ";
            txtKQ.Text += lstWeb.SelectedItem.ToString();
        }
    }
}
