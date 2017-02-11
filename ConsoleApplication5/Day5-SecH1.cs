using System;

namespace ConsoleApplication5
{
    class Day5_SecH1
    {
        //H1: Test if it's InString
        static bool InString(string s1, string s2)//s1 long;s2 short
        {
            bool iscontain = (s1.ToUpper()).Contains(s2.ToUpper());//mind the upper and lower
            if (iscontain)
                return true; //bool cannot be returned
            else
                return false;
        }
        
        public static void Main()
        {
            Console.WriteLine(InString("The Brown fox", "bro"));

        }
    }
}
