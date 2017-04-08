using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCatch
{
    class Program
    {
        static void Main()
        {
            // You can use an empty catch block.
            try
            {
                DivideByZero();
            }
            catch
            {
                Console.WriteLine("0");
            }
            // You can specify a variable in the catch.
            try
            {
                DivideByZero();
            }
            catch (Exception ex)
            {
                Console.WriteLine("1");
            }
            // You can use multiple catch blocks.
            try
            {
                DivideByZero();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("2");
            }
            catch
            {
                Console.WriteLine("3");
            }
            Console.ReadLine();
        }

        static int DivideByZero()
        {
            int value1 = 1;
            int value2 = int.Parse("0");
            return value1 / value2;
        }
    }
}
