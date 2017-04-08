using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {   // Read all text
            String s = System.IO.File.ReadAllText("C:\\Users\\MacOS\\Desktop\\Building Applications using Csharp(Application programming).txt");
           Console.WriteLine("All text result: {0}",s);
            // Read all line
            String[] arr = System.IO.File.ReadAllLines("C:\\Users\\MacOS\\Desktop\\Building Applications using Csharp(Application programming).txt");
            //Console.WriteLine("All line result: {0}", arr[0]);
            // Write file
            String output = "fpt.com.vn";
         //   System.IO.File.WriteAllText("C:\\demo\\data.txt", output);

            // Append file
            String output2 = "google.com";
            //System.IO.File.AppendAllText("C:\\demo\\data.txt", output2);

            Console.ReadKey();


        }
    }
}
