using System;
using System.Collections.Generic;
using System.Text;

namespace Example04
{
    //khai bao de
    public delegate void Deldisplay();
    class Example04
    {
        string id = "Fpt";
        string name = "Aptech";
        //event define
        public event Deldisplay startEvent;
        //khai bao method
        public void show()
        {
            Console.WriteLine("Your id:" + id);
            Console.WriteLine("Your name:" + name);
        }
        public void TestShow()
        {
            startEvent();
        }
        //        public static void Main()
        //        {
        //            Example04 obj = new Example04();
        //            obj.startEvent += new Deldisplay(obj.show);
        ////            obj.startEvent += new Deldisplay(obj.show);
        //            obj.startEvent();
        //        }
    }
    class Test
    {
        public static void Main()
        {
            Example04 obj = new Example04();
            obj.startEvent += new Deldisplay(obj.show);
            obj.startEvent += new Deldisplay(obj.show);

            // obj.startEvent();
            obj.TestShow();
        }
    }

}
