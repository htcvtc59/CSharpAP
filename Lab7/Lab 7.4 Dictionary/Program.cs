using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employees> dic = new Dictionary<string, Employees>();
            int choice;
            do
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Edit");
                Console.WriteLine("3.Remove");
                Console.WriteLine("4.Display");
                Console.WriteLine("5.Exit");
                Console.Write("You choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new EmployeeManager().add(dic);
                        break;
                    case 2:
                        new EmployeeManager().edit(dic);
                        break;
                    case 3:
                        new EmployeeManager().remove(dic);
                        break;
                    case 4:
                        new EmployeeManager().display(dic);
                        break;
                    case 5:
                        break;
                }
            } while (choice != 5);
        }
    }
}
