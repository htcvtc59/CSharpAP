using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Example03
{
    public delegate int startDelegate();
    class Contact
    {
        string id;
        string Name;
        string address;
        string mobile;
        public Contact(string id, string Name, string address, string mobile)
        {
            this.id = id;
            this.Name = Name;
            this.address = address;
            this.mobile = mobile;
        }
        public Contact()
        {
            id = string.Empty;
            Name = string.Empty;
            address = string.Empty;
            mobile = string.Empty;
        }
        public Contact input()
        {
            string id;
            string Name;
            string address;
            string mobile;

            Console.WriteLine("Enter id:");
            id = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter Mobile:");
            mobile = Console.ReadLine();

            return (new Contact(id, Name, address, mobile));
        }
    }
    class TestContact
    {
        static int menu()
        {
            Console.WriteLine("1. Input list of Contact");
            Console.WriteLine("3. Display Contacts");
            Console.WriteLine("3. Exit");
            Console.WriteLine("----------");
            Console.WriteLine("Enter your choice:");
            int option = Convert.ToInt32(Console.ReadLine());
            return (option);
        }
        static void Main(String[] args)
        {
            ArrayList a = new ArrayList();
            int option;
            string s;
            Contact objContact = new Contact();
            startDelegate objDel = new startDelegate(menu);

            do
            {
                option = objDel();
                switch (option)
                {
                    case 1: do
                        {
                            a.Add(objContact.input());
                            Console.WriteLine("Ban co tiep tuc nhap?[]y/n");
                            s = Console.ReadLine();
                        }
                        while (string.Equals(s, "y"));
                        break;
                    case 2:
                    case 3: Environment.Exit(1); break;

                }
            } while (option != 3);
        }
    }

}
