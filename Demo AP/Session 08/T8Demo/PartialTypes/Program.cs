using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialTypes
{
    public partial class CoOrds
    {
        private int x;
        private int y;

        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class CoOrds
    {
        public void PrintCoOrds()
        {
            System.Console.WriteLine("CoOrds: {0},{1}", x, y);
        }

    }

    class TestCoOrds
    {
        static void Main()
        {
            CoOrds myCoOrds = new CoOrds(10, 15);
            myCoOrds.PrintCoOrds();
            Console.ReadLine();
        }
    }

}
