using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    class Program
    {
        public static void SampleMethod(string name)
        {
            Console.WriteLine("Welcome :" + name);
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static bool Login(string uid)
        {
            if (uid == "anadi")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Action<string> action1 = SampleMethod;
            Func<int, int, int> func1 = Add;
            Predicate<string> pred1 = Login;
            action1("Tutorial Point");
            Console.ReadKey();
        }
    }
}
