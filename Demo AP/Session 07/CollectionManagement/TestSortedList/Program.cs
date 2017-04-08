using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TestSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager man = new StudentManager();

            do
            {
                Console.WriteLine("1. Accept");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Modify");
                Console.WriteLine("4. Exit");

                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        man.Accept();
                        break;

                    case 2:
                        man.Display();
                        break;
                    case 3:
                        man.Modify();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            while (true);
        }
    }

    class StudentManager
    {
        SortedList arrStudent;

        public StudentManager()
        {
            arrStudent = new SortedList();
        }

        public void Accept()
        {
            char ch = 'y';
            do
            {
                Console.Write("Enter a student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter a student address: ");
                string address = Console.ReadLine();


                arrStudent.Add(name, address);

                Console.Write("Continue?: [Y/N] :  ");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'y' || ch == 'Y');
        }

        public void Display()
        {
            for(int i=0;i<arrStudent.Count;i++) 
            {
                Console.WriteLine(arrStudent.GetKey(i) + ",  " + arrStudent.GetByIndex(i));
            }

            //IEnumerator i = arrStudent.GetEnumerator();
            //while(i.MoveNext())
            //{
            //    Console.WriteLine(i.Current.ToString());
            //}

            
        }

        public void Modify()
        {
            Console.Write("Enter a student name: ");
            string name = Console.ReadLine();

            if (arrStudent.Contains(name))
            {
                Console.Write("Enter a new Address: ");
                string address = Console.ReadLine();

                int nIndex = arrStudent.IndexOfKey(name);
                arrStudent.SetByIndex(nIndex, address);

            }
            else
                Console.WriteLine("Not Found");


        }

    }
}
