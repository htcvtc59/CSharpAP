using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousMethod
{
    class Program
    {
        // Create the delegate
        public delegate void Display(string message);
        static void Main(string[] args)
        {
            // Creation of delegate with an anonymous method
            Display newDisplay = delegate(string msg)
            {
                // Anonymous method body
                Console.WriteLine(msg);
            };
 
            // Invoke
            newDisplay("Hello World using Anonymous methods.");
            Console.ReadLine();
        }
    }
}
