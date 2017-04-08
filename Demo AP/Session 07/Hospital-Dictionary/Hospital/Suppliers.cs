/*
 * Suppliers.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Hospital
{
    /// <summary>
    /// The program demonstrates the use of the Dictionary Generic class 
    /// of the System.Collections.Generic namespace.
    /// 
    /// Class Suppliers accepts and displays the details of suppliers.
    /// </summary>
    /// /// <remarks>The class also performs additional operations,
    /// such as removing or searching for the name of supplier</remarks>
    class Suppliers
    {
        /// <summary>
        /// Creating an object of the Dictionary Generic class.
        /// </summary>
        public Dictionary<int, string> objSupplierDetails = new Dictionary<int, string>();

        /// <summary>
        /// Method to accept the id and name of supplier.
        /// </summary>
        public void AcceptDetails()
        {
            // Integer variable to store the id of supplier
            int id;

            // String variable to store the name of supplier
            string name;

            // Character variable to store the choice
            char choice = 'Y';

            try
            {
                do
                {
                    Console.Write("Enter the supplier ID : ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the name : ");
                    name = Console.ReadLine();
                    // Add() method is used to add details of the supplier to the list
                    objSupplierDetails.Add(id, name);
                    Console.Write("Do you want to add more records? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }

        /// <summary>
        /// Method to display the details of supplier.
        /// </summary>
        public void DisplayDetails()
        {
            // Storing the keys into an instance of ICollection interface
            ICollection objCollection = objSupplierDetails.Keys;

            Console.WriteLine("Details of Suppliers :");
            Console.WriteLine("Supplier ID \t Name");
            foreach (int details in objCollection)
            {
                Console.WriteLine(details + "\t\t " + objSupplierDetails[details]);
            }
            Console.WriteLine("Total number of suppliers : " + objSupplierDetails.Count);
        }

        /// <summary>
        /// Method to modify the name of supplier.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public bool Modify()
        {
            int id;
            string name;
            Console.Write("Enter the supplier ID to change the name : ");
            id = Convert.ToInt32(Console.ReadLine());
            if (id > 0 && objSupplierDetails.ContainsKey(id))
            {
                Console.Write("Enter new name of the supplier : ");
                name = Console.ReadLine();

                objSupplierDetails[id] = name;
                return true;

            }
            else
                return false;
        }

        /// <summary>
        /// Method to remove the record of supplier.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public bool Remove()
        {
            int input;
            Console.Write("Enter the supplier ID : ");
            input = Convert.ToInt32(Console.ReadLine());
            // ContainsKey() method is used to check if the particular supplier id is present in the list
            if (input > 0 && objSupplierDetails.ContainsKey(input))
            {
                // Remove() method is used to remove details of the supplier from the list
                objSupplierDetails.Remove(input);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method to search for the record of supplier.
        /// </summary>
        public void Search()
        {
            int choice;
            Console.Write("Enter the supplier ID : ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 0)
            {
                // ContainsKey() method is used to check if the particular supplier id is present in the list
                if (objSupplierDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Supplier ID : {0}", choice);
                    // Displaying name of the supplier using the Item property
                    Console.WriteLine("Name : {0}", objSupplierDetails[choice]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
