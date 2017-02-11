using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecH3
    {
        //H3 Convert int to Hex
        static string Hex(int n)
        {
            return n.ToString("X");//Convert int to Hex
        }

        public static void Main()
        { 
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}'s hex = {1}", i, Hex(i));
            }
        }
    }
}
