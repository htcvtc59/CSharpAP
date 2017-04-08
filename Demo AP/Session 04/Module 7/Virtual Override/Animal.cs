using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualOverride
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Every animal dees something");
        }
    }
}
