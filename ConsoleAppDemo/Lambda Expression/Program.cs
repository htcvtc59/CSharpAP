using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    delegate int Del(int x, int y);
    delegate void Del1(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Del del = (x, y) => x * y;
            Del1 del1 = x =>
            {
                Console.WriteLine(x * x);
                Console.WriteLine("Program ended...");
            };
            del1(2);
            int result = del(4, 6);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
