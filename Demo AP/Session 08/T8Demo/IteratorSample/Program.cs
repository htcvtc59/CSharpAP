using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorSample
{
    public class DaysOfTheWeek : System.Collections.IEnumerable
    {
        string[] days = { "Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat" };

        public System.Collections.IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }

    class TestDaysOfTheWeek
    {
        static void Main()
        {
            // Create an instance of the collection class
            DaysOfTheWeek week = new DaysOfTheWeek();

            // Iterate with foreach
            foreach (string day in week)
            {
                System.Console.Write(day + " ");
            }
            Console.ReadLine();
        }
    }
    // Output: Sun Mon Tue Wed Thr Fri Sat

}
