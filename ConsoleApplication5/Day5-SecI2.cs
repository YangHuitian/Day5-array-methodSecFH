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
                b[w] = r.Next(-5, 6);//if change Random nums from -5~5
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
            
            
            //print 2 lists
            Console.WriteLine("Number\tCount");
            for (int j=0; j<=a.Length - 1; j++)
            {
                Console.WriteLine("  {0}\t  {1}", a[j], num[j]);
            }


            //print histogram
            Console.WriteLine("Number");
            for (int j = 0; j <= a.Length - 1; j++)
            {
                Console.Write("  {0}  ", a[j]);
                for (int u = 0; u <=num[j]; u++)
                {
                    if (u < num[j])
                        Console.Write("*");
                    else
                        Console.WriteLine("*");//the last * must be WL
                }
            }

        }
    }
}
