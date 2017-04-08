using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOutOfMemoryException
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program attempts to create a string of 2.1 billion characters.
            // ... This results in an out-of-memory error.
            // ... It would require 4.2 billion bytes (4 gigabytes).
            try
            {
                string value = new string('a', int.MaxValue);
            }
            catch(OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
