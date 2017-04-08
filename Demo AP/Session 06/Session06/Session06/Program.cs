using System;
using System.Collections.Generic;
using System.Text;

namespace Session06
{
    //khai bao delegate
    public delegate int maxDelegate(int a, int b, int c);
    class Example01
    {
        static int max(int a, int b, int c)
        {
            int max;
            max = (a > b) ? a : b;
            max = (max > c) ? max : c;
            return (max);
        }
        static void Main(string[] args)
        {

            //cho delegate tham chieu den phuong thuc max
            maxDelegate objDel = new maxDelegate(Example01.max);
            Console.Write("Max = {0}", objDel(500, 200, 100));

        }
    }

}
