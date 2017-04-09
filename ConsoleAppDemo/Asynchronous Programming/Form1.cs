﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchronous_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static void BigTask()
        {
            Thread.Sleep(4000);
        }
        private async void btnBig_Click(object sender, EventArgs e)
        {
            await Task.Run(new Action(BigTask));
            label1.Text = "Task Done...";
        }
        private void btnMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

       
    }
}
