using System;

namespace PB_March_2_2016_4_Division
{
    class division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double division2Count = 0.0;
            double division3Count = 0.0;
            double division4Count = 0.0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    division2Count++;
                }
                if (num % 3 == 0)
                {
                    division3Count++;
                }
                if (num % 4 == 0)
                {
                    division4Count++;
                }
            }

            double division2Perc = division2Count / n * 100;
            double division3Perc = division3Count / n * 100;
            double division4Perc = division4Count / n * 100;

            Console.WriteLine("{0:f2}%", division2Perc);
            Console.WriteLine("{0:f2}%", division3Perc);
            Console.WriteLine("{0:f2}%", division4Perc);
        }
    }
}