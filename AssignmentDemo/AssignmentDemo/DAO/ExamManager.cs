using AssignmentDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.DAO
{
    class ExamManager
    {

        public Exam loadExamById(String id)
        {
            Exam ex = null;
            SqlConnection con = DBConnection.getConnection();
            con.Open();
            string sql = "select * from exam where id=@id";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ex = new Exam();
                ex.id = id;
                ex.description = reader.GetString(1);

                cmd.CommandText = "select * from question where id in (select question_id from exam_question where exam_id=@id)";

                reader.Close();
                reader = cmd.ExecuteReader();
                ex.questionList = new List<Question>();
                while (reader.Read())
                {
                    var q = new Question();
                    q.id = reader.GetInt32(0);
                    q.content = reader.GetString(1);
                    q.is_multible_answers = reader.GetBoolean(2);
                    //TODO load answer by question
                    var con2 = DBConnection.getConnection();
                    con2.Open();
                    var cmd2 = con2.CreateCommand();
                    cmd2.CommandText = "select * from answer where question_id=@id";
                    cmd2.Parameters.AddWithValue("@id", q.id);
                    var reader2 = cmd2.ExecuteReader();
                    q.answerList = new List<Answer>();
                    while (reader2.Read())
                    {
                        Answer a = new Answer();
                        a.id = reader2.GetInt32(0);
                        a.content = reader2["content"].ToString();
                        q.answerList.Add(a);
                    }
                    ex.questionList.Add(q);
                    // End load question
                }
                con.Close();
            }
            return ex;
        }
    }
}
