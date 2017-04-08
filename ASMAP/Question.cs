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

namespace ASMAP
{
    public partial class FrmQuestion : Form
    {
        private SqlDbConnect con;

        public FrmQuestion()
        {
            InitializeComponent();
            con = new SqlDbConnect();
            refreshMaDe();
            refreshDataGrid();
        }
        private void refreshMaDe()
        {
            con.SqlQuery("select * from dbo.MADE");
            cbbAllMaDe.DataSource = con.QueryEx();
            cbbAllMaDe.DisplayMember = "MaDe";
            cbbAllMaDe.ValueMember = "TenDe";
        }
        private void refreshDataGrid()
        {
            con.SqlQuery("select * from dbo.CAUHOI");
            dgvQues.DataSource = con.QueryEx();
        }
        private void FrmQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCauHoi.Text != "" && txtMaDe.Text != "" && txtCauHoi.Text != "" && txtDapA.Text != "" && txtDapB.Text != "" && txtDapC.Text != "" && txtDapD.Text != "" && txtDapAn.Text != "")
                {
                    con.SqlQuery("insert into dbo.CAUHOI values(@MaCauHoi,@MaDe,@CauHoi,@DapA,@DapB,@DapC,@DapD,@DapAn)");
                    con.Cmd.Parameters.Add("@MaCauHoi", txtMaCauHoi.Text.Trim());
                    con.Cmd.Parameters.Add("@MaDe", txtMaDe.Text.Trim());
                    con.Cmd.Parameters.Add("@CauHoi", txtCauHoi.Text.Trim());
                    con.Cmd.Parameters.Add("@DapA", txtDapA.Text.Trim());
                    con.Cmd.Parameters.Add("@DapB", txtDapB.Text.Trim());
                    con.Cmd.Parameters.Add("@DapC", txtDapC.Text.Trim());
                    con.Cmd.Parameters.Add("@DapD", txtDapD.Text.Trim());
                    con.Cmd.Parameters.Add("@DapAn", txtDapAn.Text.Trim());
                    con.NonQueryEx();
                    MessageBox.Show("Thêm Thành Công!");
                    refreshDataGrid();
                    txtMaCauHoi.Clear();
                    txtMaDe.Clear();
                    txtCauHoi.Clear();
                    txtDapA.Clear();
                    txtDapB.Clear();
                    txtDapC.Clear();
                    txtDapD.Clear();
                    txtDapAn.Clear();
                    txtMaCauHoi.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAddMaDe_Click(object sender, EventArgs e)
        {
            if (txtAddMaDe.Text != "" && txtTenDe.Text != "")
            {
                con.Cmd.CommandText = "insert into dbo.MADE (MaDe,TenDe) values('" + txtAddMaDe.Text + "',N'" + txtTenDe.Text + "')";
                con.NonQueryEx();
                MessageBox.Show("Thêm Thành Công!");
                txtAddMaDe.Clear();
                txtTenDe.Clear();
                txtAddMaDe.Focus();
                refreshMaDe();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCauHoi.Text != "" && txtMaDe.Text != "" && txtCauHoi.Text != "" && txtDapA.Text != "" && txtDapB.Text != "" && txtDapC.Text != "" && txtDapD.Text != "" && txtDapAn.Text != "")
                {
                    con.SqlQuery("update dbo.CAUHOI set MaDe=@MaDe,CauHoi=@CauHoi,DapA=@DapA,DapB=@DapB,DapC=@DapC,DapD=@DapD,DapAn=@DapAn where MaCauHoi=@MaCauHoi");
                    con.Cmd.Parameters.Add("@MaCauHoi", txtMaCauHoi.Text.Trim());
                    con.Cmd.Parameters.Add("@MaDe", txtMaDe.Text.Trim());
                    con.Cmd.Parameters.Add("@CauHoi", txtCauHoi.Text.Trim());
                    con.Cmd.Parameters.Add("@DapA", txtDapA.Text.Trim());
                    con.Cmd.Parameters.Add("@DapB", txtDapB.Text.Trim());
                    con.Cmd.Parameters.Add("@DapC", txtDapC.Text.Trim());
                    con.Cmd.Parameters.Add("@DapD", txtDapD.Text.Trim());
                    con.Cmd.Parameters.Add("@DapAn", txtDapAn.Text.Trim());
                    con.NonQueryEx();
                    MessageBox.Show("Sửa Thành Công!");
                    refreshDataGrid();
                    txtMaCauHoi.Clear();
                    txtMaDe.Clear();
                    txtCauHoi.Clear();
                    txtDapA.Clear();
                    txtDapB.Clear();
                    txtDapC.Clear();
                    txtDapD.Clear();
                    txtDapAn.Clear();
                    txtMaCauHoi.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCauHoi.Text != "" && txtMaDe.Text != "" && txtCauHoi.Text != "" && txtDapA.Text != "" && txtDapB.Text != "" && txtDapC.Text != "" && txtDapD.Text != "" && txtDapAn.Text != "")
                {
                    DialogResult xoaMaCauHoi = MessageBox.Show("Bạn có muốn xóa câu này trong đề", "Xóa Đề", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (xoaMaCauHoi == DialogResult.Yes)
                    {
                        con.Cmd.CommandText = "delete from dbo.CAUHOI where MaCauHoi='" + txtMaCauHoi.Text + "'";
                        con.NonQueryEx();
                        refreshDataGrid();
                        txtMaCauHoi.Clear();
                        txtMaDe.Clear();
                        txtCauHoi.Clear();
                        txtDapA.Clear();
                        txtDapB.Clear();
                        txtDapC.Clear();
                        txtDapD.Clear();
                        txtDapAn.Clear();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dgvQues_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtMaCauHoi.Text = dgvQues.SelectedRows[0].Cells[0].Value.ToString();
                txtMaDe.Text = dgvQues.SelectedRows[0].Cells[1].Value.ToString();
                txtCauHoi.Text = dgvQues.SelectedRows[0].Cells[2].Value.ToString();
                txtDapA.Text = dgvQues.SelectedRows[0].Cells[3].Value.ToString();
                txtDapB.Text = dgvQues.SelectedRows[0].Cells[4].Value.ToString();
                txtDapC.Text = dgvQues.SelectedRows[0].Cells[5].Value.ToString();
                txtDapD.Text = dgvQues.SelectedRows[0].Cells[6].Value.ToString();
                txtDapAn.Text = dgvQues.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                con.SqlQuery("select * from dbo.CAUHOI where MaCauHoi like N'%" + txtSearch.Text + "%'or MaDe like N'%" + txtSearch.Text + "%' or DapA like N'%" + txtSearch.Text + "%' or DapB like N'%" + txtSearch.Text + "%' or DapC like N'%" + txtSearch.Text + "%' or DapD like N'%" + txtSearch.Text + "%'");
                dgvQues.DataSource = con.QueryEx();
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
            txtMaCauHoi.Clear();
            txtMaDe.Clear();
            txtCauHoi.Clear();
            txtDapA.Clear();
            txtDapB.Clear();
            txtDapC.Clear();
            txtDapD.Clear();
            txtDapAn.Clear();
        }
        private void btnXoaMaDe_Click(object sender, EventArgs e)
        {
            DialogResult xoaMaDe = MessageBox.Show("Bạn có muốn xóa mã đề không?", "Xóa Mã Đề", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xoaMaDe == DialogResult.Yes)
            {
                con.Cmd.CommandText = "delete from dbo.MADE where MaDe='" + cbbAllMaDe.Text + "'";
                con.NonQueryEx();
                MessageBox.Show("Xóa mã đề thành công!");
                refreshMaDe();
            }
        }
    }
}
