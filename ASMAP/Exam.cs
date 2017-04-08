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
    public partial class FrmExam : Form
    {
        private SqlDbConnect con;
        private List<ExAnswer> anwserC = new List<ExAnswer>();
        ExAnswer Ques = new ExAnswer();
        int anwsers = 0;
        int j;
        int nAnswers = 0;
        float scores = 0;


        public FrmExam()
        {
            InitializeComponent();
            con = new SqlDbConnect();
            refreshMaDe();
            beforeStart(false);
        }



        private void refreshMaDe()
        {
            con.SqlQuery("select * from dbo.MADE");
            cbbMaDe.DataSource = con.QueryEx();
            cbbMaDe.DisplayMember = "MaDe";
            cbbMaDe.ValueMember = "TenDe";
        }
        private void beforeStart(bool value)
        {
            grbox.Enabled = value;
            btnFinish.Enabled = value;
            btnNext.Enabled = value;
            btnPrevious.Enabled = value;
            richtxtQuestion.Enabled = value;
        }

        /* private void LoadDe()
         {
             con.SqlQuery("select * from dbo.CAUHOI where MaDe='" + cbbMaDe.Text + "'");
             con.QueryBS();
             richtxtQuestion.DataBindings.Add(new Binding("Text", con._bs, "CauHoi"));
             lbA.DataBindings.Add(new Binding("Text", con._bs, "DapA"));
             lbB.DataBindings.Add(new Binding("Text", con._bs, "DapB"));
             lbC.DataBindings.Add(new Binding("Text", con._bs, "DapC"));
             lbD.DataBindings.Add(new Binding("Text", con._bs, "DapD"));
             lbCauTong.Text = "Câu " + (con._bs.Position + 1) + "/" + (con._bs.Count);
             cbbMaDe.Enabled = false;
             btnStart.Enabled = false;
             txtTime.Enabled = false;
             timeExam.Start();
             anwsers = con._bs.Position;
         }*/

        private void TotalScores()
        {
            for (int i = 0; i < anwserC.Count; i++)
            {
                if (anwserC[i].BanChon == anwserC[i].DapAn)
                {
                    nAnswers++;
                    scores = scores + (float)10 / anwserC.Count;
                }
                lbAnCorrect.Text = "Bạn đúng " +" "+ nAnswers + "/" + anwserC.Count.ToString()+" Câu";
                lbTotalFinish.Text = scores.ToString() +" "+" Điểm";
            }
        }
        private int checkedAnswer()
        {
            if (radA.Checked == true || radB.Checked == true || radC.Checked == true || radD.Checked == true)
                return 1;
            return 0;
        }
        private void saveAnswer()
        {
            if (checkedAnswer() == 1)
            {
                if (radA.Checked == true)
                    anwserC[anwsers].BanChon = "1";
                if (radB.Checked == true)
                    anwserC[anwsers].BanChon = "2";
                if (radC.Checked == true)
                    anwserC[anwsers].BanChon = "3";
                if (radD.Checked == true)
                    anwserC[anwsers].BanChon = "4";
            }
            else
                anwserC[anwsers].BanChon = "0";
        }
        private void statusAnswer(string rad)
        {
            if (rad == "1")
                radA.Checked = true;
            else if (rad == "2")
                radB.Checked = true;
            else if (rad == "3")
                radC.Checked = true;
            else if (rad == "4")
                radD.Checked = true;
            else
            {
                radA.Checked = false;
                radB.Checked = false;
                radC.Checked = false;
                radD.Checked = false;
            }
        }
        private void TaoDe()
        {
            con.SqlQuery("select * from dbo.CAUHOI where MaDe='" + cbbMaDe.Text + "' ORDER BY NEWID()");
            con.SqlReader = con.Cmd.ExecuteReader();
            while (con.SqlReader.Read())
            {
                ExAnswer Ques = new ExAnswer();
                Ques.CauHoi = con.SqlReader["CauHoi"].ToString();
                Ques.DapA = con.SqlReader["DapA"].ToString();
                Ques.DapB = con.SqlReader["DapB"].ToString();
                Ques.DapC = con.SqlReader["DapC"].ToString();
                Ques.DapD = con.SqlReader["DapD"].ToString();
                Ques.DapAn = con.SqlReader["DapAn"].ToString();
                anwserC.Add(Ques);
            }
            con.SqlReader.Close();
        }
        private void LoadDe()
        {
            richtxtQuestion.Text = (anwsers + 1).ToString() + ". " + anwserC[0].CauHoi;
            lbA.Text = anwserC[0].DapA;
            lbB.Text = anwserC[0].DapB;
            lbC.Text = anwserC[0].DapC;
            lbD.Text = anwserC[0].DapD;

            cbbMaDe.Enabled = false;
            btnStart.Enabled = false;
            txtTime.Enabled = false;
            timeExam.Start();
        }
        private void FrmExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTime.Text != "" && Convert.ToInt32(txtTime.Text) != 0)
                {
                    j = Convert.ToInt32(txtTime.Text) * 60;
                    if (cbbMaDe.Text.Substring(0, 2) == "MD")
                    {
                        TaoDe();
                        LoadDe();
                        beforeStart(true);
                        btnPrevious.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập thời gian thi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (anwsers <= anwserC.Count - 1)
                {
                    anwsers--;
                    if (anwsers >= 0)
                    {
                        statusAnswer(anwserC[anwsers].BanChon);
                        richtxtQuestion.Text = (anwsers + 1).ToString() + ". " + anwserC[anwsers].CauHoi;
                        lbA.Text = anwserC[anwsers].DapA;
                        lbB.Text = anwserC[anwsers].DapB;
                        lbC.Text = anwserC[anwsers].DapC;
                        lbD.Text = anwserC[anwsers].DapD;
                    }
                    else
                    {
                        anwsers = 0;
                    }
                }
                if (anwsers == 0)
                    btnPrevious.Enabled = false;
                if (anwsers < anwserC.Count)
                    btnNext.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (anwsers <= anwserC.Count - 2)
                {
                    anwsers++;
                    statusAnswer(anwserC[anwsers].BanChon);
                    richtxtQuestion.Text = (anwsers + 1).ToString() + ". " + anwserC[anwsers].CauHoi;
                    lbA.Text = anwserC[anwsers].DapA;
                    lbB.Text = anwserC[anwsers].DapB;
                    lbC.Text = anwserC[anwsers].DapC;
                    lbD.Text = anwserC[anwsers].DapD;
                }
                if (anwsers == anwserC.Count - 1)
                    btnNext.Enabled = false;
                if (anwsers < anwserC.Count)
                    btnPrevious.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult finish = MessageBox.Show("Bạn chắc chắn muốn nộp bài?", "Kết thúc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (finish == DialogResult.Yes)
            {
                TotalScores();
                timeExam.Stop();
                beforeStart(false);
            }

        }
        private void timeExam_Tick(object sender, EventArgs e)
        {
            j--;
            lbTimeEnd.Text = j / 60 + ":" + ((j % 60) >= 10 ? (j % 60).ToString() : "0" + j % 60);
            if (j == 0)
            {
                lbTimeEnd.Text = "0";
                timeExam.Stop();
                TotalScores();
                beforeStart(false);
            }
        }
        private void radA_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }
        private void radB_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }
        private void radC_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }
        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            saveAnswer();
        }
    }
}
