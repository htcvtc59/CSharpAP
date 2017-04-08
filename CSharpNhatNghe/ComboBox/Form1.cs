using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "Bạn đã chọn website ";
            txtKQ.Text += cbWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbWeb.ValueMember = "Link Website";
            cbWeb.Items.Add("Tuổi trẻ");
            cbWeb.Items.Add("Thanh niên");
            cbWeb.Items.Add("VNExpress");
            cbWeb.Items.Add("Dân trí");
            cbWeb.Items.Add("Công an");
            cbWeb.SelectedItem = "Tuổi trẻ";
            
        }
    }
}
