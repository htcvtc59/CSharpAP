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
    public partial class FDisplay : Form
    {
        public FDisplay()
        {
            InitializeComponent();
        }

        private void FDisplay_Load(object sender, EventArgs e)
        {
            FLogin flogin = new FLogin();
            flogin.ShowDialog();
        }
    }
}
