using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string symbol = "";
            string name = "";
            float weight=0;
            Console.WriteLine("Atomic Information" + "\n" + "==================");
            do
            {
                Console.Write("Enter atomic number :");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("No Sym Name Weight");
                    Console.WriteLine("------------------------------------");
                    
                }
                else
                {
                    Console.Write("Enter symbol :");
                    symbol = Console.ReadLine();
                    Console.Write("Enter full name :");
                    name = Console.ReadLine();
                    Console.Write("Enter atomic weight :");
                    weight = float.Parse(Console.ReadLine());

                }


            } while (number==0);






            Console.ReadLine();
        }
    }
}
