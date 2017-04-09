using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    partial class MyClass
    {
        public void M1()
        {
            Console.WriteLine("M1");
        }
    }
    partial class MyClass
    {
        public void M2()
        {
            Console.WriteLine("M2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.M1();
            m.M2();
            Console.ReadKey();
        }
    }
}
