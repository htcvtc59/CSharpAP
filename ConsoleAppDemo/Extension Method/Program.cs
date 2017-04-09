using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 535324243;
            int result = num1.GetDigits();
            Console.WriteLine("Digits: "+result);
            Console.Read();
        }
    }
}
