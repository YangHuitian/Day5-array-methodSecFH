using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Day5_SecF3
    {
        //F3 Students and their subject marks, average, total, standard deviation
        
        static void Main()
        {

            double[,] s = new double[2, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 96 } };
            double stave = 0;

            //s = {(56,84,68,29),(94,73,31,96)}
            Console.WriteLine("Sub1\tSub2\tSub3\tSub4\tStuto\tStuav");
            for (int r = 0; r <= s.GetLength(0) - 1; r++)
            {
                double sttotal = 0;//every student turn to 0
                for (int c = 0; c <= s.GetLength(1) - 1; c++)
                {
                    Console.Write("{0}\t", s[r, c]);
                    sttotal += s[r, c];
                }
                stave = sttotal / s.GetLength(1);
                Console.WriteLine("{0}\t{1}", sttotal, stave);
            }



            double clave = 0;
            Console.WriteLine("claSub1\tclaSub2\tclaSub3\tclaSub4\tstan1\tstan2\tstan3\tstan4");
            for (int i = 0; i <= s.GetLength(1) - 1; i++)
            {
                double clatotal = 0;//every sub turn to 0
                double sumofxm = 0;//every sub turn to 0 //sum of (x-M)2
                double standeviation = 0;
                for (int j = 0; j <= s.GetLength(0) - 1; j++)
                {
                    clatotal += s[j, i];
                }
                clave = clatotal / s.GetLength(0);
                Console.Write("{0}\t", clave);
                for (int k = 0; k <= s.GetLength(0) - 1; k++)
                {
                    sumofxm  += Math.Pow((s[k, i] - clave),2);
                }
                standeviation = Math.Sqrt(sumofxm / s.GetLength(0));
                Console.Write("{0}\t", standeviation);
            }
        }
    }
}

