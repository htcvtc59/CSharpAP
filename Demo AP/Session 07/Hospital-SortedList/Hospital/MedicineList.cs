/*
 * MedicineList.cs
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
    /// The program demonstrates the use of the SortedList class 
    /// of the Collections namespace.
    /// 
    /// Class MedicineList accepts and displays the names of medicines
    /// in a sorted order.
    /// </summary>
    class MedicineList
    {
        /// <summary>
        /// Creating an object of the SortedList class.
        /// </summary>
        public SortedList objMedicineDetails = new SortedList();

        /// <summary>
        /// Method to accept the name and price of medicine.
        /// </summary>
        public void AcceptDetails()
        {
            // String variable to store the name of medicine
            string name;

            // Double variable to store the price of medicine
            double price;

            // Character variable to store the choice
            char choice = 'Y';

            try
            {
                do
                {
                    Console.Write("Enter the medicine name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter the price : ");
                    price = Convert.ToDouble(Console.ReadLine());
                    // Add() method of SortedList class is used to add details of the medicine to the list
                    objMedicineDetails.Add(name, price);
                    Console.Write("Do you want to add more names? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }

        /// <summary>
        /// Method to display the details of medicines.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine("Details of Medicines :");
            Console.WriteLine("Medicine Name \t Price");
            for (int i = 0; i < objMedicineDetails.Count; i++)
            {
                // Displaying the details of medicine using GetKey() and GetByIndex() methods.
                Console.WriteLine("{0}\t\t {1:C2}", objMedicineDetails.GetKey(i), objMedicineDetails.GetByIndex(i));
            }
            //Count property of the SortedList class is used to display total count
            Console.WriteLine("Total number of medicines : " + objMedicineDetails.Count);
        }

        /// <summary>
        /// Method to modify the price of medicine.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public bool Modify()
        {
            string name;
            double price;
            Console.Write("Enter the name of the medicine to change its price : ");
            name = Console.ReadLine();
            // Contains() method of SortedList class is used to check for medicine name in the list
            if (objMedicineDetails.Contains(name))
            {
                Console.Write("Enter new price : ");
                price = Convert.ToDouble(Console.ReadLine());
                // IndexOfKey() method is used to retrieve the index of the specified medicine name from the list 
                int index = objMedicineDetails.IndexOfKey(name);

                // SetByIndex() method is used to modify the price of Medicine at the specific index
                objMedicineDetails.SetByIndex(index, price);
                return true;

            }
            else
                return false;
        }

        /// <summary>
        /// Method to remove the details of medicine.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the medicine : ");
            choice = Console.ReadLine();
            // Contains() method is used to check for the name of medicine in the list
            if (objMedicineDetails.Contains(choice))
            {
                // Remove() method is used to remove details of the medicine from the list
                objMedicineDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method to search for the name of medicine.
        /// </summary>
        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the medicine : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                // ContainsKey() method is used to check for the name of medicine in the list
                if (objMedicineDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Medicine Name : {0}", choice);
                    // Displaying price of the medicine using the Item property
                    Console.WriteLine("Price : {0:C2}", objMedicineDetails[choice]);



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
