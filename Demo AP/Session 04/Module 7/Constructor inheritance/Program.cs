using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor_inheritance
{
    /*
     In the code, the class Animal consists of two constructors, one without a parameter and the other
     with a string parameter. The class Canine is inherited from the class Animal. The derived class Canine
     consists of a constructor that invokes the constructor of the base class Animal by using the base keyword. If
     the base keyword does not take a string in the parenthesis, the constructor of the class Animal that does
     not contain parameters is invoked. In the class Details, when the derived class 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Canine objCanine = new Canine();
        }
    }
}
