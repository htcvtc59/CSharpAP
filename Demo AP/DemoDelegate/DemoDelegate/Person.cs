using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public delegate void BiDanh(int times);
    class Person
    {
        public event BiDanh biDanh;
        public void noidieu() {
            Console.WriteLine("vua noi dieu xong");
            biDanh.Invoke(10);
        }

    }
}
