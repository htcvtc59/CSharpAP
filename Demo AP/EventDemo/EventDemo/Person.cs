using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Person
    {
        public delegate void OpenedLaptop(String name);

        public event OpenedLaptop openedLaptopEvent;
        public String name;
        public void openLaptop() {
            Console.WriteLine("{0} opened laptop", name);
            if (openedLaptopEvent != null)
            {
                 openedLaptopEvent.Invoke(name);
            }
        }

        public void demo() {
            if (openedLaptopEvent != null)
            {
                openedLaptopEvent.Invoke(name);
            }
        
        }
        
    }
}
