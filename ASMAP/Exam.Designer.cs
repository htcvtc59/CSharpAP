namespace ASMAP
{
    partial class FrmExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbbMaDe = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timeExam = new System.Windows.Forms.Timer(this.components);
            this.lbTimeStart = new System.Windows.Forms.Label();
            this.lbMaDe = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lbMinute = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.richtxtQuestion = new System.Windows.Forms.RichTextBox();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radD = new System.Windows.Forms.RadioButton();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.lbD = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbTimeFinish = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtGuide = new System.Windows.Forms.TextBox();
            this.lbTimeEnd = new System.Windows.Forms.Label();
            this.lbCauTong = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalFinish = new System.Windows.Forms.Label();
            this.lbAnCorrect = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.grbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbMaDe
            // 
            this.cbbMaDe.FormattingEnabled = true;
            this.cbbMaDe.Location = new System.Drawing.Point(78, 24);
            this.cbbMaDe.Name = "cbbMaDe";
            this.cbbMaDe.Size = new System.Drawing.Size(121, 21);
            this.cbbMaDe.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.Location = new System.Drawing.Point(143, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timeExam
            // 
            this.timeExam.Interval = 1000;
            this.timeExam.Tick += new System.EventHandler(this.timeExam_Tick);
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.AutoSize = true;
            this.lbTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimeStart.Location = new System.Drawing.Point(6, 59);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(66, 16);
            this.lbTimeStart.TabIndex = 3;
            this.lbTimeStart.Text = "Thời Gian";
            // 
            // lbMaDe
            // 
            this.lbMaDe.AutoSize = true;
            this.lbMaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaDe.Location = new System.Drawing.Point(6, 25);
            this.lbMaDe.Name = "lbMaDe";
            this.lbMaDe.Size = new System.Drawing.Size(47, 16);
            this.lbMaDe.TabIndex = 4;
            this.lbMaDe.Text = "Mã Đề";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lbMinute);
            this.panel.Controls.Add(this.txtTime);
            this.panel.Controls.Add(this.lbMaDe);
            this.panel.Controls.Add(this.lbTimeStart);
            this.panel.Controls.Add(this.cbbMaDe);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(213, 109);
            this.panel.TabIndex = 3;
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(140, 62);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(29, 13);
            this.lbMinute.TabIndex = 5;
            this.lbMinute.Text = "Phút";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(78, 59);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(56, 20);
            this.txtTime.TabIndex = 2;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(33, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // richtxtQuestion
            // 
            this.richtxtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richtxtQuestion.Location = new System.Drawing.Point(278, 12);
            this.richtxtQuestion.Name = "richtxtQuestion";
            this.richtxtQuestion.Size = new System.Drawing.Size(584, 109);
            this.richtxtQuestion.TabIndex = 7;
            this.richtxtQuestion.Text = "";
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(6, 22);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(32, 17);
            this.radA.TabIndex = 8;
            this.radA.TabStop = true;
            this.radA.Text = "A";
            this.radA.UseVisualStyleBackColor = true;
            this.radA.CheckedChanged += new System.EventHandler(this.radA_CheckedChanged);
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(6, 58);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(32, 17);
            this.radB.TabIndex = 9;
            this.radB.TabStop = true;
            this.radB.Text = "B";
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.radB_CheckedChanged);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(6, 100);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(32, 17);
            this.radC.TabIndex = 10;
            this.radC.TabStop = true;
            this.radC.Text = "C";
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.radC_CheckedChanged);
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(6, 142);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(33, 17);
            this.radD.TabIndex = 11;
            this.radD.TabStop = true;
            this.radD.Text = "D";
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radD_CheckedChanged);
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.lbD);
            this.grbox.Controls.Add(this.lbC);
            this.grbox.Controls.Add(this.lbB);
            this.grbox.Controls.Add(this.lbA);
            this.grbox.Controls.Add(this.radA);
            this.grbox.Controls.Add(this.radD);
            this.grbox.Controls.Add(this.radB);
            this.grbox.Controls.Add(this.radC);
            this.grbox.Location = new System.Drawing.Point(278, 127);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(584, 171);
            this.grbox.TabIndex = 12;
            this.grbox.TabStop = false;
            this.grbox.Text = "Đáp án";
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(45, 144);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(0, 13);
            this.lbD.TabIndex = 15;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(45, 102);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(0, 13);
            this.lbC.TabIndex = 14;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(44, 60);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(0, 13);
            this.lbB.TabIndex = 13;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(45, 22);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(0, 13);
            this.lbA.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(493, 336);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(53, 36);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(577, 336);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 36);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTimeFinish
            // 
            this.lbTimeFinish.AutoSize = true;
            this.lbTimeFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimeFinish.Location = new System.Drawing.Point(19, 243);
            this.lbTimeFinish.Name = "lbTimeFinish";
            this.lbTimeFinish.Size = new System.Drawing.Size(114, 16);
            this.lbTimeFinish.TabIndex = 0;
            this.lbTimeFinish.Text = "Thời Gian Còn Lại";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFinish.Location = new System.Drawing.Point(757, 337);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(80, 35);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "Nộp Bài";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtGuide
            // 
            this.txtGuide.BackColor = System.Drawing.SystemColors.Info;
            this.txtGuide.Enabled = false;
            this.txtGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGuide.Location = new System.Drawing.Point(12, 127);
            this.txtGuide.Multiline = true;
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.Size = new System.Drawing.Size(213, 96);
            this.txtGuide.TabIndex = 0;
            this.txtGuide.Text = "+Hướng dẫn :\r\n-Bạn hãy chọn mã đề \r\n-Bạn hãy nhập thời gian \r\n-Rồi bạn bấm bắt đầ" +
    "u\r\n\r\n";
            // 
            // lbTimeEnd
            // 
            this.lbTimeEnd.AutoSize = true;
            this.lbTimeEnd.Location = new System.Drawing.Point(139, 245);
            this.lbTimeEnd.Name = "lbTimeEnd";
            this.lbTimeEnd.Size = new System.Drawing.Size(19, 13);
            this.lbTimeEnd.TabIndex = 17;
            this.lbTimeEnd.Text = "00";
            // 
            // lbCauTong
            // 
            this.lbCauTong.AutoSize = true;
            this.lbCauTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCauTong.Location = new System.Drawing.Point(229, 17);
            this.lbCauTong.Name = "lbCauTong";
            this.lbCauTong.Size = new System.Drawing.Size(0, 15);
            this.lbCauTong.TabIndex = 18;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(19, 291);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(74, 16);
            this.lbTotal.TabIndex = 19;
            this.lbTotal.Text = "Tổng Điểm";
            // 
            // lbTotalFinish
            // 
            this.lbTotalFinish.AutoSize = true;
            this.lbTotalFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalFinish.ForeColor = System.Drawing.Color.Black;
            this.lbTotalFinish.Location = new System.Drawing.Point(99, 291);
            this.lbTotalFinish.Name = "lbTotalFinish";
            this.lbTotalFinish.Size = new System.Drawing.Size(0, 16);
            this.lbTotalFinish.TabIndex = 20;
            // 
            // lbAnCorrect
            // 
            this.lbAnCorrect.AutoSize = true;
            this.lbAnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAnCorrect.ForeColor = System.Drawing.Color.Black;
            this.lbAnCorrect.Location = new System.Drawing.Point(19, 268);
            this.lbAnCorrect.Name = "lbAnCorrect";
            this.lbAnCorrect.Size = new System.Drawing.Size(0, 16);
            this.lbAnCorrect.TabIndex = 21;
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 384);
            this.Controls.Add(this.lbAnCorrect);
            this.Controls.Add(this.lbTotalFinish);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbCauTong);
            this.Controls.Add(this.lbTimeEnd);
            this.Controls.Add(this.txtGuide);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lbTimeFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.richtxtQuestion);
            this.Controls.Add(this.panel);
            this.Name = "FrmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExam_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaDe;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbMaDe;
        private System.Windows.Forms.Label lbTimeStart;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox richtxtQuestion;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbTimeFinish;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtGuide;
        private System.Windows.Forms.Label lbTimeEnd;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbCauTong;
        private System.Windows.Forms.Timer timeExam;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalFinish;
        private System.Windows.Forms.Label lbAnCorrect;
    }
}