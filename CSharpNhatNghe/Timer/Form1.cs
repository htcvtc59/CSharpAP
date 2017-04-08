﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 20;
        private void btnStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = i.ToString();
            i--;
            if (i < 0) {
                Timer.Enabled = false;
            }
        }
    }
}
