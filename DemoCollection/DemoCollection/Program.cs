using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollection
{
    class Program
    {
        static void DemoList()
        {
            List<string> data = new List<string>();
            data.Add("Ha Noi");
            data.Add("Ha Nam");
            data.Add("Hai Phong");
            data.Add("HCM");
            data.Add("Da Nang");

            //List<string> result = data.FindAll(x => x.Contains("Ha"));
            //result.ForEach(x => Console.WriteLine(x));

            //data.ForEach(x => { if (x.Contains("Ha")) Console.WriteLine(x); });

            data.FindAll(x => x.Contains("Ha")).ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            Console.WriteLine(data[0]);
        }
        static void DemoDictonary()
        {
            Console.WriteLine(".............");
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Apple", "Apple Inc");
            dict.Add("Google", "Alphabet Inc");
            Console.WriteLine(dict["Apple"]);
            //var key = dict.Keys;
            Dictionary<string,string>.KeyCollection key = dict.Keys;
            var value = dict.Values;
            value.ToList().ForEach(x => Console.WriteLine(x));
            
        }
        static void Main(string[] args)
        {
            DemoList();
            DemoDictonary();
            Console.ReadKey();
        }
    }
}
