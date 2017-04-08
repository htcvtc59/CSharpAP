using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T8Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //add two numbers
            list.Add(100);
            list.Add(200);
            //uncomment the below line to see complie error
            //list.Add("Hell");
            //list.Add(1.5);

            //get 2 number2 from the list without casting
            int number1 = list[0];
            int number2 = list[1];
            Console.Out.WriteLine("number1: " + number1);
            Console.Out.WriteLine("number1: " + number2);
            Console.ReadLine();

        }
    }
}
