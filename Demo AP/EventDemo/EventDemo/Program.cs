using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void processOpenedLaptop(string name) {
            Console.WriteLine(name + " se choi game");
        }
        static void process2(string name) {
            Console.WriteLine("Choi game xong toi se xem phim");
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Dat";
            person.openedLaptopEvent += processOpenedLaptop;
            person.openedLaptopEvent += process2;
            person.openLaptop();
            Console.Read();


        }
    }
}
