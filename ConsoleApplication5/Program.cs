using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.9 quiz: test matriculation number
            Console.Write("Enter a matriculation num: ");
            string m = Console.ReadLine().ToUpper();

            if (m.Length == 7)
            {
                int a = Convert.ToInt32(m.Substring(1, 1));
                int b = Convert.ToInt32(m.Substring(2, 1));
                int c = Convert.ToInt32(m.Substring(3, 1));
                int d = Convert.ToInt32(m.Substring(4, 1));
                int e = Convert.ToInt32(m.Substring(5, 1));
                int sum = 6 * a + 5 * b + 4 * c + 3 * d + 2 * e;
                int r = sum % 5;
                string last = "";

                //switch (r)
                //{
                    //case 0:
                        //last = "O";
                        //break;
                    //case 1:
                        //last = "P";
                        //break;
                    //....
                //}

                if (r == 0)
                    last = "O";
                else if (r == 1)
                    last = "P";
                else if (r == 2)
                    last = "Q";
                else if (r == 3)
                    last = "R";
                else
                    last = "S";

                if (last == m.Substring(6, 1))
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            else
                Console.WriteLine("Invalid");


        }
    }
}
