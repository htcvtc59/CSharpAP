using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortList
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int CompareTo(Student other)
        {
            if (this.Name.CompareTo(other.Name) == 0)
            {
                if (Age > other.Age)
                    return 1;
                if (Age < other.Age)
                    return -1;
                if (Age == other.Age)
                    return 0;
            }
            return this.Name.CompareTo(other.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>() {
                new Student("A",12),
                new Student("A",22),
                new Student("A",62),
                new Student("A",43),
                new Student("A",41)
        };
            Console.WriteLine("Before sort");
            list.ForEach(x => Console.WriteLine(x.Name + " : " + x.Age));
            list.Sort();
            Console.WriteLine("Last sort");
            list.ForEach(x => Console.WriteLine(x.Name + " : " + x.Age));
            int st = list.BinarySearch(new Student("A", 30));
            Console.WriteLine(st);
            Console.ReadLine();
        }
    }
}
