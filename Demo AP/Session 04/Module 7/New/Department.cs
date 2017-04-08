using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New
{
    class Department : Employees
    {
        int _deptId = 501;
        String _deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID: " + _deptId);
            Console.WriteLine("Department Name: " + _deptName);
        }

    }
}
