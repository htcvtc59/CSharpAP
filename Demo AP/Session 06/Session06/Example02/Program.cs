using System;
using System.Collections.Generic;
using System.Text;

namespace Example02
{
    //khai bao delegate
    public delegate int maxDelegate(int a, int b, int c);
    delegate void displayDel();
    class Example02
    {
        int max(int a, int b, int c)
        {
            int max;
            max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            return (max);
        }
        void display()
        {
            Console.WriteLine("FPT Aptech");
        }
        static void Main(string[] args)
        {

            //cho delegate tham chieu den phuong thuc max
            Example02 obj = new Example02();
            //maxDelegate objDel = new maxDelegate(obj.max);
            displayDel objDel2 = new displayDel(obj.display);
            objDel2 += new displayDel(obj.display);
            objDel2 += new displayDel(obj.display);

            objDel2();


            //Console.Write("Max = {0}",objDel(500, 200, 100));

        }

    }
}
