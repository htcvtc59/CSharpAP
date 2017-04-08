using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_StreamReader
{
    class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public Student(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Program
    {
        public List<Student> AddList(List<Student> list)
        {

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            string age = Console.ReadLine();
            list.Add(new Student(name, age));
            return list;
        }
        public void Save(List<Student> list)
        {
            using (StreamWriter sw = new StreamWriter("C:/Users/MacOS/documents/visual studio 2017/Projects/StreamWriter StreamReader/StreamWriter StreamReader/WriteSaveRead/name.txt",true))
            { list.ForEach(x => { sw.WriteLine("Full Name: " + x.Name); sw.WriteLine("Age: " + x.Age); }); }

        }
        public void ReadFile()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("C:/Users/MacOS/documents/visual studio 2017/Projects/StreamWriter StreamReader/StreamWriter StreamReader/WriteSaveRead/name.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public void Display(List<Student> list)
        {
            list.ForEach(x => Console.WriteLine("\n\tFull Name: " + x.Name + "\n\tAge: " + x.Age + "\n"));

        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            int choose;
            do
            {
                Console.WriteLine("1.Add-List\n2.Save\n3.Read-File\n4.Display-List\n5.Exit");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        new Program().AddList(list);
                        break;
                    case 2:
                        new Program().Save(list);
                        break;
                    case 3:
                        new Program().ReadFile();
                        break;
                    case 4:
                        new Program().Display(list);
                        break;
                    case 5:
                        break;

                }
            } while (choose != 5);
        }
    }
}
