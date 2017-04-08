using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        public delegate void Increment(ref int x);
        public static void Add2(ref int x)
        {
            x += 2;
        }
        public static void Add3(ref int x)
        {
            x += 3;
        }
        static void Main(string[] args)
        {
            Increment functionDelegate = Add2;
            functionDelegate += Add3;
            functionDelegate += Add2;
            int x = 5;
            functionDelegate(ref x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
