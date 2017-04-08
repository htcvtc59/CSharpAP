using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_AP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Phone Name: ");
            string name = Console.ReadLine();
            Console.Write("Phone Type: ");
            string type = Console.ReadLine();
            Console.Write("Phone Price: ");
            float price = float.Parse(Console.ReadLine());
            MobilePhone mobile = new MobilePhone(name, type, price);
            mobile.Display();
            Console.ReadLine();

        }
    }
}
