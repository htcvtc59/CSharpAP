using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {

       

        static void Main(string[] args)
        {
            PrimeNumbers prime = new PrimeNumbers();
            Console.Write("Prime Number: ");
            int number = int.Parse(Console.ReadLine());
            prime.range = number;
            prime.OnPrimeNumber += Prime_OnPrimeNumber;
            prime.Run();

            Console.ReadLine();
        }

        private static void Prime_OnPrimeNumber(int i)
        {
            Console.WriteLine(i);
        }
    }
}
