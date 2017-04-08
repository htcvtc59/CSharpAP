using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_StreamReader
{
    class Program
    {
        public void ReadData() {
            FileStream fs = new FileStream("c:\\users\\macos\\documents\\visual studio 2017\\Projects\\StreamWriter FileStream\\FileStream StreamReader\\name.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0,SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null) {
                Console.WriteLine("{0}",str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            new Program().ReadData();
            Console.Read();
        }
    }
}
