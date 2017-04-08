using AssignmentDemo.DAO;
using AssignmentDemo.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AssignmentDemo
{
    public partial class Form1 : Form
    {
        int x = 27;
        int y = 46;
        const int yOriginal = 46;
        int i = 0;
        
        int answerId = 0;
        Exam exam;
        Question question;
        List<Question> questionsAnswered;
        public Form1()
        {
            InitializeComponent();


        }

        void renderQuestion()
        {
            
            questionLabel.Text = question.content;
            y = yOriginal;
            answerPanel.Controls.Clear();
            question.answerList.ForEach(a =>
            {
              
                y += 30;
                if (question.is_multible_answers)
                {


                }else
                {
                    var btn = new MyRadioBtn();
                    btn.Click += Btn_Click;
                    btn.Text = a.content;
                    btn.answer_id = a.id;
                    btn.Location = new Point(x, y);
                    answerPanel.Controls.Add(btn);
                }



            });

        }

        private void Btn_Click(object sender, EventArgs e)
        {
           var q= questionsAnswered.Find(x => x.id == question.id);
            var source = (MyRadioBtn)sender;
           var answer= question.answerList.Find(x => x.id == source.answer_id);
            q.dapAn = answer;
            Console.WriteLine(answer.content);
        }

        private void loadExamBtn_Click(object sender, EventArgs e)
        {
            string examId = examIdTxt.Text;
            ExamManager manager = new ExamManager();
            exam = manager.loadExamById(examId);
            questionsAnswered = new List<Question>();
            exam.questionList.ForEach(x => {
                Question q = new Question();
                q.id = x.id;
                questionsAnswered.Add(q);
            });
            if (exam == null)
            {
                MessageBox.Show("Exam: " + examId + " ko ton tai !");
            }
            else if (exam.questionList.Count >= 0)
            {
                question = exam.questionList[0];
                renderQuestion();
            }
            else
            {
                MessageBox.Show("Exam ko co cau hoi");

            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;
            if (i < exam.questionList.Count)
            {
                question = exam.questionList[i];
                renderQuestion();
            }else
            {
                questionsAnswered.ForEach(x =>
                {
                    Console.WriteLine(x.dapAn.content);
                   
                });
                MessageBox.Show("Ko next dc dau em");
            }
        }
    }
}
