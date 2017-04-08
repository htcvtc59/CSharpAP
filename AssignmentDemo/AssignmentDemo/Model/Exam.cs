using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.Model
{
    class Exam
    {
        public string id { get; set; }
        public string description { get; set; }
        public List<Question> questionList { get; set; }
    }
}
