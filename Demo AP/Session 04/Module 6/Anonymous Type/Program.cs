﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anonymous Type with three properties.
            var stock = new { Name = "Michgan Enterprises", Code = 1301, Price = 35056.75 };
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Stock Code: " + stock.Code);
            Console.WriteLine("Stock Price: " + stock.Price);
        }

        public static void Main1(string[] args)
        {
            Employee david = new Employee();
            // Creating the anonymous type instance and    
            // passing it to a method.
            david.DisplayDetails(new { FirstName = "David", LastName = "Blake", Age = 30 });
        }
    }
}
