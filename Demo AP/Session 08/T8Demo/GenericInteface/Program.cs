using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInteface
{
    class Program
    {
        //this is a generic inteface
        interface GenericInterface<T>
        {
            T getValue(T tValue);
        }
        //A class that implements Interface
        class MyClass<T> : GenericInterface<T>
        {
            public T getValue(T tValue)
            {
                return tValue;
            }
        }

        static void Main(string[] args)
        {
            GenericInterface<int> intObject = new MyClass<int>();
            GenericInterface<string> stringObject = new MyClass<string>();

            Console.WriteLine("{0}", intObject.getValue(5));
            Console.WriteLine("{0}", stringObject.getValue("Hi there."));
            Console.ReadLine();
        }
    }
}
