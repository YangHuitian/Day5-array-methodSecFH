using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecI2
    {
        //I2      Random 5 nums, histogram

        public static void Main()
        {
            int[] a = new int[10];// create an array from 0~9
            for (int i = 0; i <= a.Length -1; i++)
            {
                a[i] = i;
            }

            int[] b = new int[50];// create an array of 50 nums from 0~9
            Random r = new Random();
            for (int w = 0; w <= b.Length -1; w++) 
            {
                b[w] = r.Next(0, 10);
            }

            int[] num = new int[10];// create an array of counts
            for (int ii = 0; ii < a.Length; ii++)
            {
                for (int ww = 0;ww < b.Length; ww++)
                {
                    if (b[ww] == a[ii])
                    {
                        num[ii] += 1;
                    }
                }
            }
            //Console.WriteLine(String.Join(" ", a));
            //Console.WriteLine(String.Join(" ", b));
            //Console.WriteLine(String.Join(" ", num));

            Console.WriteLine("Number\tCount");
            for (int j=0; j<=a.Length - 1; j++)
            {
                Console.WriteLine("  {0}\t  {1}", a[j], num[j]);
            }

       
            
        }
    }
}
