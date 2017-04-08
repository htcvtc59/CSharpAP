using System;
using System.Collections.Generic;
using System.Text;

namespace DemoExceptionProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = 1 / int.Parse("0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("HelpLink = {0}", ex.HelpLink);
                Console.WriteLine("Message = {0}", ex.Message);
                Console.WriteLine("Source = {0}", ex.Source);
                Console.WriteLine("StackTrace = {0}", ex.StackTrace);
                Console.WriteLine("TargetSite = {0}", ex.TargetSite);
            }
            Console.ReadLine();
        }
    }
}
