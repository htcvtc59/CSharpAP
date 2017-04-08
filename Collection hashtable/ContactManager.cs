using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class ContactManager
    {
        public Hashtable add(Hashtable hash)
        {
            Contact contact = new Contact();
            Console.WriteLine("Contact Name: ");
            contact.ContactName = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            if (contact.ContactName.Length != 0 && contact.PhoneNumber.Length != 0)
            {
                hash.Add(contact.ContactName, contact.PhoneNumber);
            }
            return hash;
        }
        public void display(Hashtable hash)
        {
            ICollection key = hash.Keys;
            Console.WriteLine("\t\t" + "Address Book" + "\t\t");
            Console.WriteLine("\tContactName\tPhone number");
            foreach (string s in key)
            {
                Console.WriteLine("\t" + s + "\t\t" + hash[s]);
            }
        }
        public Hashtable search(Hashtable hash)
        {
            Console.WriteLine("Enter name search: ");
            string name = Console.ReadLine();
            Console.WriteLine("\n\tContactName\tPhone number");
            int flag = 0;
            ICollection key = hash.Keys;
            foreach (string s in key)
            {
                if (name.Equals(s))
                {
                    Console.WriteLine("\t" + s + "\t\t" + hash[s]);
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Not Found");
            }
            return hash;
        }
    }
}
