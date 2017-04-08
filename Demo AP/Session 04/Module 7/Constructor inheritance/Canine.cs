using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor_inheritance
{
    class Canine : Animal
    {
        //base() takes a 3tring value called "Lion"
        public Canine(): base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }
    }
}
