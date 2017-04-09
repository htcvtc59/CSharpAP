using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct MyStruct
    {
        public int Val { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct mystruct1 = new MyStruct();
            mystruct1.Val = 10;
            MyStruct mystruct2 = mystruct1;
            Console.WriteLine(mystruct2.Val);
            mystruct1.Val = 20;
            Console.WriteLine(mystruct2.Val);
            Console.ReadKey();
        }
    }
}
