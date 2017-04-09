using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Method
{
    delegate int Del(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Del del = delegate (int x)
            {
                Console.WriteLine("This is anonymous method");
                return 0;
            };
            Console.Read();
        }
    }
}
