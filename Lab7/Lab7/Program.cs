﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Product
    {
        string name;
        double cost;
        int onhand;
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dicayList inv = new dicayList();
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));
            Console.WriteLine("Product list:");
            foreach (Product i in inv)
            {
                Console.WriteLine(" " + i);
            }
            Console.ReadLine();
        }
    }
}
