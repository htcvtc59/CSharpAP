using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public static bool IsCanadianSocialInsuranceNumber(string sSIN)
        {
            int iChecksum = 0;
            int iDigit = 0;

            for (int i = 0; i < sSIN.Length; i++)
            {
                if (((i + 1) % 2) == 0)
                {
                    iDigit = int.Parse(sSIN.Substring(i, 1)) * 2;
                    iChecksum += (iDigit < 10) ? iDigit : iDigit - 9;
                }
                else
                {
                    iChecksum += int.Parse(sSIN.Substring(i, 1));
                }
            }

            return ((iChecksum % 10) == 0) ? true : false;
        }
        static void Main(string[] args)
        {
            string SIN;

            Console.WriteLine("SIN Validator\n" + "=============");
            do
            {
                Console.Write("SIN (0 to quit : ");
                SIN = Console.ReadLine();
                if (SIN == "0")
                {
                    Console.WriteLine("Have a Nice Day!");
                }
                else if (IsCanadianSocialInsuranceNumber(SIN))
                {
                    Console.WriteLine("This is a valid SIN.");
                }
                else if (IsCanadianSocialInsuranceNumber(SIN) == false)
                {
                    Console.WriteLine("This is not a valid SIN.");
                }
            } while (true);

            Console.ReadLine();

        }
    }
}
