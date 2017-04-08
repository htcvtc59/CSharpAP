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
        public Dictionary<string, Employees> add(Dictionary<string, Employees> dic)
        {
            Employees emp = new Employees();
            Random rand = new Random();
            Console.Write("Name: ");
            emp.name = Console.ReadLine();
            Console.Write("Age: ");
            emp.age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Salary: ");
            emp.salary = Double.Parse(Console.ReadLine());
            if (emp.name.Length != 0 && emp.age.ToString().Length != 0 && emp.salary.ToString().Length != 0)
            {
                dic.Add(rand.Next(10000).ToString(), new Employees(emp.name, emp.age, emp.salary));
            }
            return dic;
        }
        public void edit(Dictionary<string, Employees> dic)
        {
            rep: Console.Write("Enter name or age or salary want to edit: ");
            string all = Console.ReadLine().Trim();
            int i = 0;
            string index = "";
            foreach (KeyValuePair<string, Employees> emp in dic)
            {
                if (all == emp.Value.name | int.Parse(all) == emp.Value.age | double.Parse(all) == emp.Value.salary)
                {
                    Console.WriteLine("\t" + emp.Value.name + "\t" + emp.Value.age + "\t" + emp.Value.salary);
                    index = emp.Key;
                    i++;
                }
            }
            if (i == 1)
            {
                dic.Remove(index);
                Employees emp = new Employees();
                Console.Write("new name: ");
                emp.name = Console.ReadLine();
                Console.Write("new age: ");
                emp.age = Convert.ToInt16(Console.ReadLine());
                Console.Write("new salary: ");
                emp.salary = Double.Parse(Console.ReadLine());
                dic[index] = new Employees(emp.name, emp.age, emp.salary);

            }
            else
                goto rep;

        }
        public void remove(Dictionary<string, Employees> dic)
        {
            rep: Console.Write("Enter name or age want to remove: ");
            string nameorage = Console.ReadLine().Trim();
            int flag = 0;
            string index = "";
            int j = 0;
            foreach (KeyValuePair<string, Employees> emp in dic)
            {
                if (nameorage.Equals(emp.Value.name, StringComparison.CurrentCultureIgnoreCase) )
                {
                    Console.WriteLine("\t" + emp.Value.name + "\t" + emp.Value.age + "\t" + emp.Value.salary);
                    index = emp.Key;
                    flag = 1;
                    j++;
                }
                else
                    goto rep;
            }
            if (flag == 1 && j == 1)
            {
                dic.Remove(index);
                Console.WriteLine("Remove success");
            }
            else
                goto rep;

        }
        public void display(Dictionary<string, Employees> dic)
        {
            Console.WriteLine("\tName\tAge\tSalary");
            foreach (KeyValuePair<string, Employees> emp in dic)
            {
                Console.WriteLine("\t" + emp.Value.name + "\t" + emp.Value.age + "\t" + emp.Value.salary);
            }
        }

    }
}
