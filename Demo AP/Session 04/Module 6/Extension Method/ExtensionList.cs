using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Method
{
    static class ExtensionList
    {
        // Extension method that accepts and returns a collection.
        public static List<T> RemoveDuplicate<T>(this List<T> allCities)
        {
            List<T> finalCities = new List<T>();
            foreach (var eachCity in allCities)
                if (!finalCities.Contains(eachCity))
                    finalCities.Add(eachCity);
            return finalCities;
        }
    }
}
