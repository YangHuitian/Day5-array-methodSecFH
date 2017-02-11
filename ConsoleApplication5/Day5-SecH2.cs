using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecH2
    {
        //H2 Test s2's position in s1
        public static int FindWood(string s1, string s2)
        {
            bool isFound = (s1.ToUpper()).Contains(s2.ToUpper());
            if (isFound)
            {
                s1 = s1.Replace(" ", "");//delete all the space
                for(int i = 0; i<= s1.Length - 1; i++)
                {
                    for (int s= 0; s<= s2.Length - 1; s++)
                    {
                        if (s1[i] == s2[s] && s1.Substring(i, s2.Length) == s2)//"ox": not stop at "ow"
                        {
                                return i+1;
                        }
                        break;
                    }
                }
            }
            return -1;

        }

        public static void Main()
        {
            Console.WriteLine(FindWood("The brown fox", "ox"));
        }
    }
}
