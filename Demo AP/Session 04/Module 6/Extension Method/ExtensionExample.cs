using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Method
{
    /// <summary>
    /// Class ExtensionExample defines the extension method
    /// </summary>
    static class ExtensionString
    {
        // Extension Method to convert the fist character to          
        // lowercase
        public static string FirstLetterLower(this string result)
        {
            if (result.Length > 0)
            {
                char[] s = result.ToCharArray();
                s[0] = char.ToLower(s[0]);
                return new string(s);
            }
            return result;
        }
    }

}
