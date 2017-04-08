using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace TestDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=MacOS;Initial Catalog=Quiz;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource tblNameBS = new BindingSource();
        QuizEntities quiz;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            quiz = new QuizEntities();
            cAUHOIBindingSource.DataSource = quiz.CAUHOIs.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cAUHOIBindingSource.EndEdit();
                quiz.SaveChangesAsync();



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtmacauhoi.Focus();
                CAUHOI cauhoi = new CAUHOI();
                quiz.CAUHOIs.Add(cauhoi);
                cAUHOIBindingSource.Add(cauhoi);
                cAUHOIBindingSource.MoveLast();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cAUHOIBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in quiz.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridView1.DataSource = cAUHOIBindingSource;

                }
                else {
                    var query = from o in cAUHOIBindingSource.DataSource as List<CAUHOI>
                                where o.MaCauHoi == txtSearch.Text || o.MaDe == txtSearch.Text||o.CauHoi1.Contains(txtSearch.Text)
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }

            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                if (MessageBox.Show("Are you want to delete","Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    quiz.CAUHOIs.Remove(cAUHOIBindingSource.Current as CAUHOI);
                    cAUHOIBindingSource.RemoveCurrent();

                }
            }
        }
    }
}
