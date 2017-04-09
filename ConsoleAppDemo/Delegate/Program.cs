using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int MyDel(int x, int y);
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            MyDel del = new MyDel(Add);
            int result = del(10, 30);
            Console.WriteLine(result);
            del += Multiply;
            result = del(10, 30);
            Console.WriteLine(result);
            Console.WriteLine("----------");
            MyDel del1 = Add;
            del1 += Multiply;
            Console.WriteLine(del1(30, 50));
            Console.ReadKey();
        }
    }
}
