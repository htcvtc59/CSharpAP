using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IInterface1
    {
        void Method1();
        void Method2();
    }
    interface IInterface2
    {
        void Method2();
    }
    class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from MyClass2");
        }
    }
    class MyClass2 : MyClass1, IInterface1,IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        void IInterface1.Method2()
        {
            Console.WriteLine("Method1 from IInterface1");
        }
        void IInterface2.Method2()
        {
            Console.WriteLine("Method2 from IInterface2");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 m2 = new MyClass2();
            IInterface1 i1 = new MyClass2();
            i1.Method1();
            IInterface2 i2 = new MyClass2();
            i2.Method2();
            Console.ReadKey();
        }
    }
}
