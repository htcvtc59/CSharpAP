using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    sealed class MyClass1
    {
        public void SsampleMethod()
        {
            Console.WriteLine("Sample Method in MyClass1");
        }
    }
    /*class MyClass2 : MyClass1
    {

    }*/


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
