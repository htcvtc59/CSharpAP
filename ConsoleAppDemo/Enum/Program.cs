using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Gender
    {
        Female = 1,
        Male = 2,
        Unknown = 3
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Anadi", Age = 12, Gender = Gender.Male };
            int gen = (int)p1.Gender;
            Console.WriteLine(gen);
            Console.Read();
        }
    }
}
