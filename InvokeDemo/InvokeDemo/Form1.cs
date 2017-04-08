using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace InvokeDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

private void cmdGenerate_Click(object sender, EventArgs e)
{
    // Chuẩn bị
    lstNumber.Items.Clear();

    // Tạo và chạy thread
    Thread thrGenerating = new Thread(new ThreadStart(DoWork));
    thrGenerating.Start();
}

private void DoWork()
{
    for (int i = 1; i <= 1000; i++)
    {
        // Thêm item vào list qua invoke
        lstNumber.Invoke(new MethodInvoker(delegate()
            {
                lstNumber.Items.Add(i);
                lstNumber.TopIndex = lstNumber.Items.Count - 1;
            }));

        // Cập nhật tiến độ qua progress bar
        pgrOperation.Invoke(new MethodInvoker(delegate()
        {
            pgrOperation.Value = (i * 100 / 1000);
        }));
    }

    MessageBox.Show("Hoàn tất");
}
    }
}
