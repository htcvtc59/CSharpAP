using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._4
{
    class Employees
    {
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }

        public Employees()
        {
            this.name = string.Empty;
            this.age = 0;
            this.salary = 0;
        }
        public Employees(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
    }
}
