/*
 * Product.cs
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
	/// The program demonstrates the use of boxing and unboxing.
	///
	/// Class Product accepts the details of the product, converts the details
	/// into reference types using boxing and displays them by converting them
	/// into their relevant types using unboxing.
	/// </summary>
	class Product
	{
		/// <summary>
		/// The entry point for the application.
		/// </summary>
		/// <param name="args"> A list of command line arguments</param>
		static void Main(string[] args)
		{
			// Creating objects of Object class to store the    
			//details of the product
			Object objProductID;
			Object objProductName;
			Object objPrice;
			Object objQuantity;

			// Accepting and converting the details of the products
			// into reference types using implicit boxing
			Console.Write("Enter the id of product : ");
			objProductID = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the name of product : ");
			objProductName = Console.ReadLine();

			Console.Write("Enter price : ");
			objPrice = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter quantity : ");
			objQuantity = Convert.ToInt32(Console.ReadLine());

			// Converting objects into their relevant types 
			// using explicit unboxing

			//            int ProductID = objProductID;   // Error occurs while unboxing

			int ProductID = (int)objProductID;
			string ProductName = (string)objProductName;
			double Price = (double)objPrice;
			int Quantity = (int)objQuantity;
			double amtPayable = (int)objQuantity * Price;

			// Displaying the details of the product
			Console.WriteLine("\nProduct Details:");
			Console.WriteLine("Product ID : " + ProductID);
			Console.WriteLine("Product Name : " + ProductName);
			Console.WriteLine("Price : $" + objPrice);
			Console.WriteLine("Quantity : " + objQuantity);
			Console.WriteLine("Amt Payable {0:F2}: ", amtPayable);
		}
	}
}
