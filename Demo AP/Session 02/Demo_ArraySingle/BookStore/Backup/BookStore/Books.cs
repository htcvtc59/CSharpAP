/*
 * Books.cs
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
	/// The program demonstrates the use of single dimensional array.
	///
	/// Class Books accepts and displays the names of books using single dimensional array.
	/// </summary>
	class Books
	{
		/// <summary>
		/// The entry point for the application.
		/// </summary>
		/// <param name="args"> A list of command line arguments</param>
		static void Main(string[] args)
		{
			// Array of string to store the book title
			string[] bookTitle = new string[6];

			// Accepting and storing the title of the books
			for (int i = 0; i < bookTitle.Length; i++)
			{
				Console.Write("Enter the title of book : ");
				bookTitle[i] = Console.ReadLine();
				Console.WriteLine();
			}

			// Displaying the title of the books
			Console.WriteLine("List of Books : ");
			foreach (string title in bookTitle)
			{
				Console.WriteLine(title);
			}
			//Changing the title of fourth book 
			bookTitle[3] = "Planet of the Apes";
			Console.WriteLine("Newly changed title of book 4 : " + bookTitle[3]);
		}
	}
}
