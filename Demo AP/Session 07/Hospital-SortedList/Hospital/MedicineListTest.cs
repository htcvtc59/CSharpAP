/*
 * MedicineListTest.cs
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
    /// Class MedicineListTest is used to test the MedicineList class.
    /// </summary>
    class MedicineListTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args">A list of command line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // Creating an object of the MedicineList class
                MedicineList objMedicines = new MedicineList();

                // Invoking the AcceptDetails method of the MedicineList class 
                // to accept the details of the medicines
                objMedicines.AcceptDetails();

                // Invoking the DisplayDetails method of the MedicineList class 
                // to display the details of the medicines
                objMedicines.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options :");
                    Console.WriteLine("  1. Modify\n  2. Remove\n  3. Remove All\n  4. Search\n  5. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Modifying the price of medicine
                            if (objMedicines.Modify())
                            {
                                Console.WriteLine("\n-----After Modifying-----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 2:
                            // Removing the details of medicine from the list
                            if (objMedicines.Remove())
                            {
                                Console.WriteLine("\n-----After Removing-----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Medicine with this name does not exist");
                            break;
                        case 3:
                            // Removing the names of all medicines using the built-in method Clear
                            objMedicines.objMedicineDetails.Clear();
                            Console.WriteLine("\n-----After removing all the medicines-----");
                            Console.WriteLine("Total number of medicines : " + objMedicines.objMedicineDetails.Count);
                            return;
                        case 4:
                            // Searching for the details of medicine
                            objMedicines.Search();
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
