using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Parallel_Library
{
    class ParallelDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.For(0, 11, i =>
            {
                Console.WriteLine("i = "+i);
                Thread.Sleep(1000);
            });
        }
    }
}
