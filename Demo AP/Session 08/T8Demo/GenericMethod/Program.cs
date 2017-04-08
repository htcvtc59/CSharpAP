using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethod
{
    class ArrayUtils
    {
        //is Bigger is a generic method
        public static bool isBigger<T>(T[] src, T[] target)
        {
            // See if target array is big enough. 
            if (target.Length < src.Length + 1)
                return false;
            return true;
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int[] nums2 = new int[4];


            //Call a generic method with int[] type
            bool b = ArrayUtils.isBigger(nums, nums2);

            Console.WriteLine(b);

            //Call a generic method with String[] type
            string[] strs = { "Generics", "are", "powerful." };
            string[] strs2 = new string[4];

            b = ArrayUtils.isBigger(strs, strs2);

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
