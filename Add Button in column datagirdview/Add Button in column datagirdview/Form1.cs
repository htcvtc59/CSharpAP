using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Button_in_column_datagirdview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }
        //update
        private void update()
        {   
            //add column
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Position";
            dataGridView1.Columns[1].Name = "Team";
            dataGridView1.Columns[2].Name = "Points";
            //add row
            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("Man Utd");
            row.Add("78");
            dataGridView1.Rows.Add(row.ToArray());
            // 2nd row
            row = new ArrayList();
            row.Add("2");
            row.Add("Man City");
            row.Add("77");
            dataGridView1.Rows.Add(row.ToArray());
            //3rd row
            row = new ArrayList();
            row.Add("3");
            row.Add("Chelsea");
            row.Add("74");
            dataGridView1.Rows.Add(row.ToArray());
            //add button column
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Button";
            btn.Name = "button";
            btn.Text = "Click me";
             btn.Width = 60;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
                MessageBox.Show((e.RowIndex+1).ToString()+" Row Clicked");
            }
        }
    }
}
