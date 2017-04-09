using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MacOS\Documents\Visual Studio 2017\Projects\ConsoleAppDemo\ManageUser\bin\Debug\ManageUser.dll";
            Assembly assembly = Assembly.LoadFile(path);
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Class: " + type.Name);
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("--Method: " + method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var param in parameters)
                    {
                        Console.WriteLine("----Parameter: " + param.Name + " : " + param.ParameterType);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
