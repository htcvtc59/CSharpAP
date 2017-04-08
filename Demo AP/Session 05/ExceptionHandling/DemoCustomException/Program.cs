using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=2;
            double b=2;
            double c=5;
            try
            {
                Triangle tr = new Triangle(a, b, c);
            }
            catch (TriangleException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new TriangleException("Invalid Triangle");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    class TriangleException : Exception
    {
        public TriangleException(String message):base(message)
        {
            
        }
    }
}
