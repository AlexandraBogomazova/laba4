using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        public static double Min (params double[] values)
        {
            double min = values[0];
            foreach (double v in values)
            {
                if (v < min)
                    min = v;
            }
            return min;
        }

        public static int SpecSum(params int[] values)
        {
            int sumchet = 0, sumnech = 0;
            foreach (int v in values)
            {
                if (v % 2 == 0)
                    sumchet += v;
                if (v % 2 != 0)
                    sumnech += v;
            }
            return sumchet - sumnech;
        }

        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Console.ReadKey();
        }

        private static void Zadanie2()
        {
            Console.WriteLine();
            Console.WriteLine(SpecSum(2, 4, 7, 10, 11));
            Console.WriteLine(SpecSum(1, 1, 1, 4));
            Console.WriteLine(SpecSum(0, 0, 0, 0, 1));
        }

        private static void Zadanie1()
        {
            Console.WriteLine(Min(2.4, 1.0, 6.8, 0.1));
            Console.WriteLine(Min(-2.4, 6.3, 5));
            Console.WriteLine(Min(-100.4, 0, 1, 2));
        }
    }
}
