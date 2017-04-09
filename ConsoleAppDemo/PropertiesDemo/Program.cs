using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Account
    {
        float init_amount;
        static float interest;
        public float InitialAmount
        {
            set
            {
                if (value < 1000)
                {
                    Console.WriteLine("Initial amount cannot be less than 1000");
                    return;
                }
                init_amount = value;
            }
            get
            {
                return init_amount;
            }

        }

        public static float InterestRate
        {
            private set { interest = value; }
            get { return interest; }
        }
        public Account()
        {
            this.InitialAmount = 10000;
        }
        public Account(float amt)
        {
            this.InitialAmount = amt;
        }
        static Account()
        {
            Account.InterestRate = 9.5f;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account();
            ac1.InitialAmount = 500;
            Console.ReadKey();
        }
    }
}
