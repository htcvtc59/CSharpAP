using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", "A");
            ht.Add("b", "B");
            ht.Add("c", "C");
            ht.Add("d", "D");
            ht["f"] = "F";
            ICollection c = ht.Keys;
            foreach (string str in c)
            {
                Console.WriteLine(str + " : " + ht[str]);
            }
            Console.ReadLine();
        }
    }
}
