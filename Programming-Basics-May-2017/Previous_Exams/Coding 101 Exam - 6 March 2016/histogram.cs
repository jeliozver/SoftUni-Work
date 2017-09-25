using System;

namespace PB_March_2016_4_Histogram
{
    class histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double over800Count = 0.0;
            double over600Count = 0.0;
            double over400Count = 0.0;
            double over200Count = 0.0;
            double under200Count = 0.0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num >= 800)
                {
                    over800Count++;
                }
                else if (num >= 600 && num <= 799)
                {
                    over600Count++;
                }
                else if (num >= 400 && num <= 599)
                {
                    over400Count++;
                }
                else if (num >= 200 && num <= 399)
                {
                    over200Count++;
                }
                else if (num < 200)
                {
                    under200Count++;
                }
            }

            double over800Perc = over800Count / n * 100;
            double over600Perc = over600Count / n * 100;
            double over400Perc = over400Count / n * 100;
            double over200Perc = over200Count / n * 100;
            double under200Perc = under200Count / n * 100;

            Console.WriteLine("{0:f2}%", under200Perc);
            Console.WriteLine("{0:f2}%", over200Perc);
            Console.WriteLine("{0:f2}%", over400Perc);
            Console.WriteLine("{0:f2}%", over600Perc);
            Console.WriteLine("{0:f2}%", over800Perc );
        }
    }
}
