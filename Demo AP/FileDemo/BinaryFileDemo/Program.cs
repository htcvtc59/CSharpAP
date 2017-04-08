using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            write();
            read();
            Console.ReadKey();
        }

        static void read() {
            var st = new FileStream("C:\\Users\\MacOS\\Documents\\Visual Studio 2017\\Projects\\Demo AP\\FileDemo\\BinaryFileDemo\\demo.dat", FileMode.OpenOrCreate);
            System.IO.BinaryReader br = new BinaryReader(st);
            
            try
            {
                var result = br.ReadDouble();
          
                Console.WriteLine(result);
            }
            catch (EndOfStreamException ex) {
                Console.WriteLine(ex.Message);
            }
           
        
        }
        static void write() {
            System.IO.BinaryWriter bw = new BinaryWriter(new FileStream("C:\\Users\\MacOS\\Documents\\Visual Studio 2017\\Projects\\Demo AP\\FileDemo\\BinaryFileDemo\\demo.dat", FileMode.Create));
            bw.Write(10000.0);
            bw.Close();
        }
    }
}
