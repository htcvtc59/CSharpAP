using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialMethod
{
    partial class Shape
    {
        partial void Create()
        {
            Console.WriteLine("Creating Shape");
        }
        public void Test()
        {
            Create();
        }
    }
}
