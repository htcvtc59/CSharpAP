using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Multi_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Method1));
            Thread thread2 = new Thread(new ThreadStart(Method2));
            thread1.IsBackground = true;
            thread1.Priority = ThreadPriority.BelowNormal;
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Program ended...");
            Console.Read();
        }
        static void Method1()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 50)
                {
                    Thread.Sleep(3000);
                    Thread.CurrentThread.Abort();
                }
                Console.WriteLine("i1: " + i);
            }
        }
        static void Method2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("i2: " + i);
            }
        }
    }
}
