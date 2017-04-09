using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class MyClass<T1, T2>
    {
        public T1 MyProperty { get; set; }
        public void Method(T1 p1, T2 p2)
        {
            Console.WriteLine("{0} -- {1}",p1,p2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int, string> obj1 = new MyClass<int, string>();
            obj1.MyProperty = 10;
            obj1.Method(10,"TutorialPoint");
            Console.ReadKey();
        }
    }
}
