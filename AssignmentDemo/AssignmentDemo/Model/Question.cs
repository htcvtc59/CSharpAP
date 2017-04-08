using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.Model
{
    class Question
    {
        public int id { get; set; }
        public string content { get; set; }
        public bool is_multible_answers { get; set; }
        public List<Answer> answerList { get; set; }
        public Answer dapAn { get; set; }
    }
}
