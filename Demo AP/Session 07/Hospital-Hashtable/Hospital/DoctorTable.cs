/*
 * DoctorTable.cs
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
    /// The program demonstrates the use of the Hashtable class 
    /// of the Collections namespace.
    /// 
    /// Class DoctorTable is a table to accept, store and display doctor details.
    /// </summary>
    /// <remarks>The class also performs additional operations,
    /// such as removing or searching for the name of a doctor</remarks>
    class DoctorTable
    {
        /// <summary>
        /// Creating an object of the Hashtable class.
        /// </summary>
        public Hashtable objDoctorDetails = new Hashtable();

        /// <summary>
        /// Method to accept the name and address of doctor.
        /// </summary>
        public void AcceptDetails()
        {
            // String variable to store the name of doctor
            string name;

            // String variable to store the address
            string address;

            // Character variable to store the choice
            char choice = 'Y';

            try
            {
                do
                {
                    Console.Write("Enter the doctor's name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter the address : ");
                    address = Console.ReadLine();
                    // Add() method of Hashtable class is used to add details of the doctor to the list
                    objDoctorDetails.Add(name, address);
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
        /// Method to display the details of doctors.
        /// </summary>
        public void DisplayDetails()
        {

            // Storing the keys into an instance of ICollection interface using the Keys property of Hashtable
            ICollection objCollection = objDoctorDetails.Keys;

            Console.WriteLine("\nDetails of doctors :");
            Console.WriteLine("Doctor's Name \t Address");
            Console.WriteLine("------------- \t -------");
            // Iterating through the collection using a foreach loop
            foreach (string details in objCollection)
            {
                Console.WriteLine(details + "\t\t " + objDoctorDetails[details]);
            }
            // Count property of Hashtable class is used to display total count of doctors
            Console.WriteLine("Total number of doctors : " + objDoctorDetails.Count);
        }

        /// <summary>
        /// Method to remove the details of doctors.
        /// </summary>
        /// <returns>Returns true or false.</returns>
        public bool Remove()
        {
            string choice;
            Console.Write("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            // ContainsKey() method is used to check if the particular key element is present in the hash table
            if (objDoctorDetails.ContainsKey(choice))
            {
                // Remove() method is used to remove details of the doctor from the list
                objDoctorDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method to search for details of the doctor.
        /// </summary>
        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                // ContainsKey() method is used to check for the doctor's name in the list
                if (objDoctorDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Doctor's Name : {0}", choice);
                    // Displaying address of the doctor using the Item property
                    Console.WriteLine("Address : {0}", objDoctorDetails[choice]);
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
