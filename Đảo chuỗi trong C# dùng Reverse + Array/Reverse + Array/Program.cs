using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse___Array
{
    class Program
    {
        public static string ReverseString(string s) {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string a = "123456789";
            string b = ReverseString(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
