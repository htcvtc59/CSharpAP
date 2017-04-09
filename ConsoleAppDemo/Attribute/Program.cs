using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Class)]
    class SampleAttribute : Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    [Sample(Id = 10, Name = "Tutorials")]
    class MyClass
    {

    }
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }


}
