using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("c://users//macos//documents//visual studio 2017//Projects//StreamWriter FileStream//StreamWriter FileStream//name.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            sw.WriteLine();
            sw.Flush();
            fs.Close();
            Console.Read();
        }
    }
}

