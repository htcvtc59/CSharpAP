/*
 * Student.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
	/// <summary>
	/// 
	/// The program demonstrates the use of operators.
	///
	/// Class Student accepts the name and marks of a student in   
	///three different subjects  and calculates the percentage and scholarship amount.
	/// </summary>
	class Student
	{
		/// <summary>
		/// The entry point for the application.
		/// </summary>
		/// <param name="args"> A list of command line arguments</param>
		static void Main(string[] args)
		{
			// String variable to store the student name
			string studentName;

			// Integer variable to store the student marks
			int english, maths, science;

			// Float variable to store student's percentage
			// and scholarship amount
			float percent = 0, amount = 0;

			// Accepting the details of the student
			Console.Write("Enter the name of the student : ");
			studentName = Console.ReadLine();

			Console.Write("Enter marks in English : ");
			english = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter marks in Maths : ");
			maths = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter marks in Science : ");
			science = Convert.ToInt32(Console.ReadLine());

			// Checking if marks are greater than or equal to zero               
			// and less than or equal to 100
			if ((english >= 0 && english <= 100) && (maths >= 0 && maths <= 100) && (science >= 0 && science <= 100))
			{
				if (english >= 35 && maths >= 35 && science >= 35)
				{

					// Calculating percentage scored by the student using arithmetic operators
					percent = ((english + maths + science) * 100) / 300;

					// Calculating scholarship amount 
					if (percent > 75)
						amount = 1500;
					else if (percent >= 60 && percent <= 75)
						amount = 1000;
					else
						amount = 0;

					// Displaying the student name, total marks and the 
					// percentage obtained by the student
					Console.WriteLine("\nStudent Name : " + studentName);
					Console.WriteLine("Total Marks : " + (english + maths + science));
					Console.WriteLine("Percentage : " + percent + "%");

					// Displaying scholarship amount for the student
					Console.WriteLine("Scholarship Amount : " + amount + "$");
				}
				else
				{
					Console.WriteLine("\nStudent Name : " + studentName);
					Console.WriteLine("Result : Failed");
				}
			}
			else
			{
				Console.WriteLine("Invalid entry of marks");
			}
		}
	}
}
