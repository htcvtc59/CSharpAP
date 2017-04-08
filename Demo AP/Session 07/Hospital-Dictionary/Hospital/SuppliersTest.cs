/*
 * SuppliersTest.cs
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
    /// Class SuppliersTest is used to test the Suppliers class.
    /// </summary>
    class SuppliersTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // Creating an object of the Suppliers class
                Suppliers objSuppliers = new Suppliers();

                // Invoking the AcceptDetails method of the Suppliers class 
                // to accept the details of the suppliers
                objSuppliers.AcceptDetails();

                // Invoking the DisplayDetails method of the Suppliers class 
                // to display the details of the suppliers
                objSuppliers.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine("  1. Modify\n  2. Remove\n  3. Remove All\n  4. Search\n  5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Modifying the name of supplier
                            if (objSuppliers.Modify())
                            {
                                Console.WriteLine("\n-----After Modifying-----");
                                objSuppliers.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Supplier with this name does not exist");
                            break;
                        case 2:
                            // Removing a record of supplier
                            if (objSuppliers.Remove())
                            {
                                Console.WriteLine("\n-----After Removing-----");
                                objSuppliers.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Supplier with this name does not exist");
                            break;
                        case 3:
                            // Removing the records of all suppliers using the built-in method Clear
                            objSuppliers.objSupplierDetails.Clear();
                            Console.WriteLine("\n-----After removing all the suppliers-----");
                            Console.WriteLine("Total number of suppliers : " + objSuppliers.objSupplierDetails.Count);
                            return;
                        case 4:
                            // Searching for the details of supplier
                            objSuppliers.Search();
                            break;
                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }
}
