using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab7._4
{
    class EmployeeManager
    {
        public dicayList add(dicayList dic)
        {
            Employees emp = new Employees();
            Console.Write("Name: ");
            emp.name = Console.ReadLine();
            Console.Write("Age: ");
            emp.age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Salary: ");
            emp.salary = Double.Parse(Console.ReadLine());
            if (emp.name.Length != 0 && emp.age.ToString().Length != 0 && emp.salary.ToString().Length != 0)
            {
                dic.Add(new Employees(emp.name, emp.age, emp.salary));
            }
            return dic;
        }
        public void edit(dicayList dic)
        {
            rep: Console.Write("Enter name or age or salary want to edit: ");
            string all = Console.ReadLine();
            int i = 0;
            int index = 0;
            foreach (Employees emp in dic)
            {
                if (all == emp.name || int.Parse(all) == emp.age || double.Parse(all) == emp.salary)
                {
                    Console.WriteLine("\t" + emp.name + "\t" + emp.age + "\t" + emp.salary);
                    index = dic.IndexOf(emp);
                    i++;
                }
            }
            if (i != 1)
            {
                goto rep;
            }
            else
            {
                dic.RemoveAt(index);
                Employees emp = new Employees();
                Console.Write("new name: ");
                emp.name = Console.ReadLine();
                Console.Write("new age: ");
                emp.age = Convert.ToInt16(Console.ReadLine());
                Console.Write("new salary: ");
                emp.salary = Double.Parse(Console.ReadLine());
                dic.Insert(index, new Employees(emp.name, emp.age, emp.salary));

            }



        }
        public void remove(dicayList dic)
        {
            rep: Console.Write("Enter name or age want to remove: ");
            string nameorage = Console.ReadLine();
            int flag = 0;
            int index = 0;
            int j = 0;
            foreach (Employees emp in dic)
            {
                if (nameorage.Equals(emp.name, StringComparison.CurrentCultureIgnoreCase) || int.Parse(nameorage) == emp.age)
                {
                    Console.WriteLine("\t" + emp.name + "\t" + emp.age + "\t" + emp.salary);
                    index = dic.IndexOf(emp);
                    flag = 1;
                    j++;
                }
            }
            if (flag == 1 && index != -1 && j == 1)
            {
                dic.RemoveAt(index);
                Console.WriteLine("Remove success");
            }
            else
                goto rep;

        }
        public void display(dicayList dic)
        {
            Console.WriteLine("\tName\tAge\tSalary");
            foreach (Employees emp in dic)
            {
                Console.WriteLine("\t" + emp.name + "\t" + emp.age + "\t" + emp.salary);
            }
        }
    }
}
