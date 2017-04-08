using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New
{
    class Employees
    {
        int _empld = 1;
        String _empName = "James Anderson";        
        public void Display()
        {
            Console.WriteLine("Employee ID: " + _empld);
            Console.WriteLine("Employee Name: " + _empName);
        }
    }
}
