using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass
{
    //Gen is a generic class
    class Gen<T>
    {
        T ob;
        public Gen(T o)
        {
            ob = o;
        }
        public T getob()
        {
            return ob;
        }
        public void showType()
        {
            Console.WriteLine("Type of T is " + typeof(T));
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            //Create a Gen class with int type
            Gen<int> iOb = new Gen<int>(102);
            iOb.showType();

            int v = iOb.getob();
            Console.WriteLine("value: " + v);

            Console.WriteLine();

            //Create a Gen class with String type
            Gen<string> strOb = new Gen<string>("Generics add power.");
            strOb.showType();
            string str = strOb.getob();
            Console.WriteLine("value: " + str);
            Console.ReadLine();
        }
    }
}
