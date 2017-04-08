using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate.Addition(10, 50));
            Calculate objCal = new Calculate();
            Console.WriteLine(objCal.Multiply(10, 20));
        }
    }
}
