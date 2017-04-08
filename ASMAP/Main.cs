using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMAP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            FrmQuestion frmQuestion = new FrmQuestion();
            frmQuestion.Visible = true;
            this.Visible = false;
            
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            FrmExam frmExam = new FrmExam();
            frmExam.Visible = true;
            this.Visible = false;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
