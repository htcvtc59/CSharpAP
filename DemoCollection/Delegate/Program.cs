using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void HelloAction(string name);
    class HelloWorld
    {
        public event HelloAction HelloActionEvent;
        public void run(string name)
        {
            HelloActionEvent.Invoke("FPT " + name);
        }


    }
    class Program
    {

        public static void viet(string s)
        {
            Console.WriteLine("Xin chao {0}", s);

        }
        public static void eng(string s)
        {
            Console.WriteLine("Hello {0}", s);

        }

        public static void DemoDelegate(string name)
        {
            HelloAction hello = new HelloAction(viet);
            hello += eng;
            hello.Invoke(name);

        }
        public static void DemoEvent(string name)
        {

            HelloWorld helloworld = new HelloWorld();
            helloworld.HelloActionEvent += viet;
            helloworld.HelloActionEvent += eng;
            helloworld.run(name);
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();
            DemoEvent(name);

            Console.ReadLine();

        }
    }
}
