using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TestComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("huy","b");
            Student stu2 = new Student("thang", "a");
            Student stu3 = new Student("tuan", "d");
            Student stu4 = new Student("tu", "c");

            StudentManager stuMan = new StudentManager();
            stuMan.Add(stu1);
            stuMan.Add(stu2);
            stuMan.Add(stu3);
            stuMan.Add(stu4);


            stuMan.Display();

        }
    }

    class Student : IComparable
    {
        public int CompareTo(object e)
        {
            Student s = (Student)e;
            return this.address.CompareTo(s.address);
        }

        public Student(string name, string add)
        {
            this.name = name;
            this.address = add;
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ToString()
        {
            return this.name + ", " + this.address;
        }

    }

    class StudentManager
    {
        ArrayList arrStudent;

        public StudentManager()
        {
            arrStudent = new ArrayList();
        }

        public void Add(Student stu)
        {
            arrStudent.Add(stu);

        }

        //public void Accept()
        //{
        //    char ch = 'y';
        //    do
        //    {
        //        Console.Write("Enter a student name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Enter a student address: ");
        //        string name = Console.ReadLine();

                

        //        arrStudent.Add(name);

        //        Console.Write("Continue?: [Y/N] :  ");
        //        ch = Convert.ToChar(Console.ReadLine());
        //    }
        //    while (ch == 'y' || ch == 'Y');
        //}

        public void Display()
        {
            arrStudent.Sort();
            //arrStudent.Reverse();
            foreach (Student var in arrStudent)
            {
                Console.WriteLine(var.ToString());
            }
        }

        public void Search()
        {
            Console.Write("Enter a student name: ");
            string name = Console.ReadLine();
            if (arrStudent.Contains(name))
            {
                Console.WriteLine("Found");
                Console.WriteLine(arrStudent[arrStudent.IndexOf(name)]);
            }
            else
                Console.WriteLine("Not Found");
        }
    }
}
