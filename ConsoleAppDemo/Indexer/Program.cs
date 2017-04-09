using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        Employee[] EmpList;
        public Department()
        {
            DepId = 10;
            DepName = "Sales";
            EmpList = new Employee[3] {
                new Employee {Id=101,EmpName="Alex",Salary = 50000 },
                new Employee {Id=102,EmpName="Brad",Salary = 45000 },
                new Employee {Id=103,EmpName="Chris",Salary = 40000 }
            };
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in EmpList)
            {
                if (id == emp.Id)
                    return emp;
            }
            return null;
        }
        public Employee GetEmployee(string name)
        {
            foreach (Employee emp in EmpList)
            {
                if (name == emp.EmpName)
                    return emp;
            }
            return null;
        }
        public Employee this[int id]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (id == emp.Id)
                        return emp;
                }
                return null;
            }
        }
        public Employee this[string name]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (name == emp.EmpName)
                        return emp;
                }
                return null;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
            Console.WriteLine(dept[101].EmpName);
            Console.WriteLine(dept["Brad"].Id);
            Console.Read();
        }
    }
}
