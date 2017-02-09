using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecF2
    {
        public static void Main()
        {
            //F2 sort a descending array

            int[] a = new int[5]{2,5,6,1,0};
            
            for (int i = 0;  i < a.Length-1; i++)//[i:0~3]
            {
                for (int k = i + 1; k < a.Length; k++)//k = i + 1 //[k:1~4]
                {
                    int temp;
                    if (a[i] < a[k])//descend
                    {
                        temp = a[i];
                        a[i] = a[k];
                        a[k] = temp;
                    }
                    Console.WriteLine(string.Join(",", a));//cannot directly WL an array
                }
            }

        }
    }
}
