using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class PrimeNumbers
    {
        private delegate void PrimeNumberFinder();
        public delegate void _OnPrimeNumber(int i);
        public int range;
        public event _OnPrimeNumber OnPrimeNumber;
        public void checkPrime()
        {
            for (int i = 1; i <= range; i++)
            {
                if (Songuyento(i))
                    OnPrimeNumber.Invoke(i);
            }

        }
        public static bool Songuyento(int n)
        {
            bool co = true;
            if (n < 2)
            {
                return !co;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n) + 1; i++)
                {
                    if (n % i == 0)
                    {
                        co = false;
                        break;
                    }
                }
            }
            return co;
        }
        public void Run()
        {
            PrimeNumberFinder finder = new PrimeNumberFinder(checkPrime);
            finder.Invoke();
        }
    }
}
