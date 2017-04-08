/*
 * Authors.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
	/// <summary>
	/// 
	/// The program demonstrates the use of Array class.
	///
	/// Class Authors accepts and displays the details of the authors using the Array class. 
	/// </summary>
	class Authors
	{
		/// <summary>
		/// The entry point for the application.
		/// </summary>
		/// <param name="args"> A list of command line arguments</param>
		static void Main(string[] args)
		{
			// Creating an object of Array class for storing author IDs of type integer
			Array objAuthorID = Array.CreateInstance(typeof(int), 3);

			// Creating objects of Array class for storing author name, address, and state name of type string
			Array objAuthorNames = Array.CreateInstance(typeof(string), 3);
			Array objAddress = Array.CreateInstance(typeof(string), 3);
			Array objState = Array.CreateInstance(typeof(string), 3);

			// String variable to store user inputs
			string input = "";

			// Accepting the details of authors using the SetValue() method
			for (int i = 0; i < objAuthorNames.Length; i++)
			{
				Console.Write("Enter the ID of author : ");
				input = Console.ReadLine();
				objAuthorID.SetValue(Convert.ToInt32(input), i);
				Console.Write("Enter the name of author : ");
				input = Console.ReadLine();
				objAuthorNames.SetValue(input, i);
				Console.Write("Enter the address : ");
				input = Console.ReadLine();
				objAddress.SetValue(input, i);
				Console.Write("Enter the name of state : ");
				input = Console.ReadLine();
				objState.SetValue(input, i);
				Console.WriteLine();
			}

			// Displaying the details of authors using the GetValue() method
			Console.WriteLine("\nDetails of the authors :\n");
			Console.WriteLine("Author ID\tName\t\tAddress\t\t\tState");
			for (int i = 0; i <= objAuthorNames.GetUpperBound(0); i++)
			{
				Console.Write(objAuthorID.GetValue(i) + "\t\t");
				Console.Write(objAuthorNames.GetValue(i) + "\t");
				Console.Write(objAddress.GetValue(i) + " \t");
				Console.WriteLine(objState.GetValue(i));
			}

			// Sorting the names of authors using the Sort() method
			Array.Sort(objAuthorNames);

			// Displaying the names of authors after sorting
			Console.WriteLine("\nAuthor names after sorting :\n");
			for (int i = 0; i <= objAuthorNames.GetUpperBound(0); i++)
			{
				Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
			}
            Console.ReadKey();

		}
	}
}
