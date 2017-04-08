using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Love_You
{
    public partial class Love : Form
    {
        public Love()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Em có yêu anh không?", "Love", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialog == DialogResult.No)
            {
                Application.Restart();
            }

        }
    }
}
