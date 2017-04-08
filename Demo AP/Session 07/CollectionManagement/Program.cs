using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Class7
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager man  = new StudentManager();

            do
            {
                Console.WriteLine("1. Accept");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");

                int n = Convert.ToInt32(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        man.Accept();
                        break;

                    case 2:
                        man.Display();
                        break;
                    case 3:
                        man.Search();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            while(true);
        }

    }

    class StudentManager
    {
        ArrayList arrStudent;

        public StudentManager()
        {
            arrStudent = new ArrayList();
        }
        
        public void Accept()
        {
            char ch = 'y';
            do
            {
                Console.Write("Enter a student name: " );
                string name = Console.ReadLine();
                arrStudent.Add(name);

                Console.Write("Continue?: [Y/N] :  ");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while(ch == 'y' || ch == 'Y');
        }

        public void Display()
        {
            foreach (string var in arrStudent)
            {
                Console.WriteLine(var);
            }
        }

        public void Search()
        {
            Console.Write("Enter a student name: ");
            string name = Console.ReadLine();
            if(arrStudent.Contains(name))
            {
                Console.WriteLine("Found");
                Console.WriteLine( arrStudent[arrStudent.IndexOf(name) ]);
            }
            else
                Console.WriteLine("Not Found");
        }

    }
}
