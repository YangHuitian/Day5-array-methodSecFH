using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecI1
    {
        //I1    Calculate num of Coins' denomination
        static string CalCoins(double input)
        {
            int z = Convert.ToInt32(100 * input);
            int h = z / 100;
            int td = (z % 100) / 10;

            int f = 0;
            int tw = 0;
            int tt = 0;

            switch (td)
            {
                case 0:
                    f = 0;
                    tw = 0;
                    tt = 0;
                    break;
                case 1:
                    f = 0;
                    tw = 0;
                    tt = 1;
                    break;
                case 2:
                    f = 0;
                    tw = 1;
                    tt = 0;
                    break;
                case 3:
                    f = 0;
                    tw = 1;
                    tt = 1;
                    break;
                case 4:
                    f = 0;
                    tw = 2;
                    tt = 0;
                    break;
                case 5:
                    f = 1;
                    tw = 0;
                    tt = 0;
                    break;
                case 6:
                    f = 1;
                    tw = 0;
                    tt = 1;
                    break;
                case 7:
                    f = 1;
                    tw = 1;
                    tt = 0;
                    break;
                case 8:
                    f = 1;
                    tw = 1;
                    tt = 1;
                    break;
                case 9:
                    f = 1;
                    tw = 2;
                    tt = 0;
                    break;
            }
            int dd;
            int d = z - 100 * h - 10 * td;
            if (d == 5)
            {
                dd = 1;
            }
            else
                dd = 0;
            string result = "$" + input + " needs "+ h + " 100-cent, " + f + " 50-cent, " + tw +" 20-cent, " + tt +" 10-cent and " + dd + " 5-cent coins.";
            return result;
        }

        public static void Main()
        {
            Console.Write("Pls enter your coins: ");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(CalCoins(i));
        }

    }
}
