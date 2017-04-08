using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // The first short will overflow after the second short does.
            short a = 0;
            short b = 100;
            try
            {
                //
                // Keep incrementing the shorts until an exception is thrown.
                // ... This is terrible program design.
                //
                while (true)
                {
                    checked
                    {
                        a++;
                    }
                    unchecked
                    {
                        b++;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                // Display the value of the shorts when overflow exception occurs.
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
