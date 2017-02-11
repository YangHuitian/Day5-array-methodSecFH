using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecH4
    {
        //H4    replace a char in a string
        static string Substitute(String s, Char c1, Char c2)
        {
            string s2 = s.Replace(c1, c2);
            return s2;
        }

        public static void Main()
        {
            Console.WriteLine(Substitute("i am a good girl.", ' ', '-'));
        }
    }
}
