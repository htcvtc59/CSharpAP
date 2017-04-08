using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_AP
{
    class MobilePhone :Phone
    {
        public MobilePhone(string phonename, string phonetype, float phoneprice) : base(phonename, phonetype, phoneprice)
        {
            base.phonetype = "Mobile";
        }
        public override void Display()
        {
            base.Display();
        }

    }
}
