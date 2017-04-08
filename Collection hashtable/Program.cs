using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Program
    {    
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            int choice;
            do {
                Console.WriteLine("1.Add new contact");
                Console.WriteLine("2.Find a contact by name");
                Console.WriteLine("3.Display contacts");
                Console.WriteLine("4.Exit");
                Console.Write("You choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new ContactManager().add(hash);
                        break;
                    case 2:
                        new ContactManager().search(hash);
                        break;
                    case 3:
                        new ContactManager().display(hash);
                        break;
                    case 4:
                        break;
                }
            } while (choice!=4);
        }
    }
}
