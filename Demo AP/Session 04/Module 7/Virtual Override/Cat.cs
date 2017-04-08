using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualOverride
{
    class Cat : Animal
    {
        //Class Cat overrides Eat() method of class Animal
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }

    }
}
