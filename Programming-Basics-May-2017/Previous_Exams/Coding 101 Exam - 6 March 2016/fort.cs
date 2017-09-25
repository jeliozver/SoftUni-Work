using System;

namespace Fort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            int height = n;
            int colLRWidth = n / 2;

            string seaglesLR = new string('^', colLRWidth);
            string spaces = new string(' ', width - 2);
            
            int underscoresCount = 0; // if n is 3 or 4
            if (n > 4)
            { 
                underscoresCount = width - colLRWidth - colLRWidth - 4;
            }
            string underscores = new string('_', underscoresCount);

            // First row
            Console.WriteLine($"/{seaglesLR}\\{underscores}/{seaglesLR}\\");

            // Body
            for (int bodyRow = 0; bodyRow < height - 3; bodyRow++)
            {
                    Console.WriteLine($"|{spaces}|");
            }

            // Last 2 rows
            spaces = new string(' ', (width - 2 - underscoresCount) / 2);
            Console.WriteLine($"|{spaces}{underscores}{spaces}|");

            string underscoresLR = new string('_', colLRWidth);
            spaces = new string(' ', underscoresCount); // Last row spaces = uncerscores
            Console.WriteLine($"\\{underscoresLR}/{spaces}\\{underscoresLR}/");
        }
    }
}