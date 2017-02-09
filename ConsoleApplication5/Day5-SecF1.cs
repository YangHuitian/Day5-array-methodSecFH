using System;
using System.Linq;

namespace ConsoleApplication5
{
    class Day5_SecF1
    {
        public static void Main()
        {
            //F1 monthly sales
            string m = "";
            double[] S = new double[12];
            for (int i = 1; i <= 12; i++)
            {
                Console.Write("sale of {0}: ", i);
                string input = Console.ReadLine();
                double sale = Convert.ToDouble(input);
                S[i-1] = sale;
                
                switch (i)
                {
                    case 1:
                        m = "Jan";
                        break;
                    case 2:
                        m = "Feb";
                        break;
                    case 3:
                        m = "Mar";
                        break;
                    case 4:
                        m = "Apr";
                        break;
                    case 5:
                        m = "May";
                        break;
                    case 6:
                        m = "Jun";
                        break;
                    case 7:
                        m = "Jul";
                        break;
                    case 8:
                        m = "Aug";
                        break;
                    case 9:
                        m = "Sep";
                        break;
                    case 10:
                        m = "Oct";
                        break;
                    case 11:
                        m = "Nov";
                        break;
                    case 12:
                        m = "Dec";
                        break;

                }
            }
            Console.WriteLine(string.Join("\t",S)); //print out array in one line
            Console.WriteLine("Max Month: {0}  {1}", m, S.Max());
            Console.WriteLine("Min Month: {0}  {1}", m, S.Min());
            Console.WriteLine("Average Monthly: {0}", S.Average());
            
            


        }
    }
}
