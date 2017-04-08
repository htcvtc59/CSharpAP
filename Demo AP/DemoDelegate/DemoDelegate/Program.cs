using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    class Program
    {
        public static void bidanhntn(int times) {
            for (int k = 0; k < times; k++) {
                Console.WriteLine("A");
            }
        
        }
        public static void bd2(int t) {
            for (int k = 0; k < t; k++)
            {
                Console.WriteLine("B");
            }
        
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.biDanh += new BiDanh(bidanhntn);
            person.biDanh += new BiDanh(bd2);
            person.noidieu();
            Console.ReadLine();
        }
    }
}
