using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_AP
{
    class Phone
    {
        protected string phonename { get; set; }
        protected string phonetype { get; set; }
        protected float phoneprice { get; set; }
        public Phone()
        {
            this.phonename = string.Empty;
            this.phonetype = string.Empty;
            this.phoneprice = 0;
        }
        public Phone(string phonename, string phonetype, float phoneprice)
        {
            this.phonename = phonename;
            this.phonetype = phonetype;
            this.phoneprice = phoneprice;
        }
        public virtual void Display()
        {
            Console.WriteLine("Phone {0}\ntype {1}\nprice {2}", phonename, phonetype, phoneprice);
        }
    }
}
