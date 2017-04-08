/*
 * DoctorTableTest.cs
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
    /// Class DoctorTableTest is used to test the DoctorTable class.
    /// </summary>
    class DoctorTableTest
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            try
            {
                // Creating an object of the DoctorTable class
                DoctorTable objDoctorsTable = new DoctorTable();

                // Invoking the AcceptDetails method of the DoctorTable class 
                // to accept the details of the doctors
                objDoctorsTable.AcceptDetails();

                // Invoking the DisplayDetails method of the DoctorTable class 
                // to display the details of the doctors
                objDoctorsTable.DisplayDetails();

                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine("  1. Remove\n  2. Remove All\n  3. Search\n  4. Exit");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            // Removing the details of the doctor
                            if (objDoctorsTable.Remove())
                            {
                                Console.WriteLine("\n-----After Removing-----");
                                objDoctorsTable.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Doctor with this name does not exist");
                            break;
                        case 2:
                            // Removing the names of all doctors using the built-in method Clear
                            objDoctorsTable.objDoctorDetails.Clear();
                            Console.WriteLine("\n-----After removing all the doctors-----");
                            Console.WriteLine("Total number of doctors : " + objDoctorsTable.objDoctorDetails.Count);
                            return;
                        case 3:
                            // Searching for the details of doctor
                            objDoctorsTable.Search();
                            break;
                        case 4:
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
