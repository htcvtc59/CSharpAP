/*
 * Employee.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
	/// <summary>
	/// 
	/// The program demonstrates the use of typecasting.
	///
	/// Class Employee accepts and displays the details of the employee and  
	/// calculates the salary.
	/// </summary>
	class Employee
	{
		/// <summary>
		/// The entry point for the application.
		/// </summary>
		/// <param name="args"> A list of command line arguments</param>
		static void Main(string[] args)
		{
			// Variables declared to store employee details
			int employeeID;
			string employeeName;
			string designation;
			float taxAmount = 0;
			double salary = 0, netSalary = 0;

			// Accepting the employee details using explicit typecasting
			Console.Write("Enter the id of an employee : ");
			employeeID = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the name of employee : ");
			employeeName = Console.ReadLine();

			Console.Write("Enter designation : ");
			designation = Console.ReadLine();

			Console.Write("Enter salary : ");
			salary = Convert.ToDouble(Console.ReadLine());

			// Calculating tax and net salary based on basic salary 
			// using explicit and implicit typecasting
			if (salary >= 10000)
			{
				taxAmount = (float)(salary * 32.5 / 100);
			}
			else
			{
				taxAmount = (float)(salary * 24.8 / 100);
			}
			netSalary = salary - taxAmount;

			// Displaying the details of the employee using explicit typecasting
			Console.WriteLine("\nEmployee Details:");
			Console.WriteLine("Employee ID : " + employeeID);
			Console.WriteLine("Employee Name : " + employeeName);
			Console.WriteLine("Designation : " + designation);
			Console.WriteLine("Salary : {0} $", salary);
			Console.WriteLine("Net Salary : {0:F2} $ is rounded off to : {1} $", netSalary, (int)netSalary);
		}
	}
}
