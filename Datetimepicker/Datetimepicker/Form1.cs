using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            display(labstatus.Text);
        }
        //Display
        private void display(string text) {
            MessageBox.Show(text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  labstatus.Text = dateTimePicker.Value.ToString();
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            labstatus.Text = dateTimePicker.Text;

        }
    }
}
