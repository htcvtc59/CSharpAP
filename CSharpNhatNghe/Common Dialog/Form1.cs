using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if(fontDialog.ShowDialog()== DialogResult.OK & !String.IsNullOrEmpty(richTextBox1.Text) )
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;
               
            }
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open File";
            openFile.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK) {
                StreamReader read = new StreamReader(File.OpenRead(openFile.FileName));
                richTextBox1.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK) {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(richTextBox1.Text);
                write.Dispose();

            }

        }

        private void btnPrintPreviewDialog_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {

        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
           
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowser.SelectedPath;
                
            }
        }
    }
}
