namespace PB_Dec_2_2017_5_Christmas_Sock
{
    using System;

    public class ChristmasSock
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 2;

            // Top three lines
            Console.WriteLine($"|{new string('-', 2 * n)}|");
            Console.WriteLine($"|{new string('*', 2 * n)}|");
            Console.WriteLine($"|{new string('-', 2 * n)}|");

            int wavesCount = 2;
            int hyphensLRCount = (width - wavesCount - 2) / 2;

            // Middle
            for (int i = 1; i <= n - 1; i++)
            {
                string waves = new string('~', wavesCount);
                string hyphens = new string('-', hyphensLRCount);

                Console.WriteLine($"|{hyphens}{waves}{hyphens}|");

                wavesCount += 2;
                hyphensLRCount--;
            }

            hyphensLRCount = 2;
            wavesCount = width - 2 - hyphensLRCount * 2;

            for (int i = 1; i <= n - 2; i++)
            {
                string waves = new string('~', wavesCount);
                string hyphens = new string('-', hyphensLRCount);

                Console.WriteLine($"|{hyphens}{waves}{hyphens}|");

                wavesCount -= 2;
                hyphensLRCount++;
            }

            // Bottom
            hyphensLRCount = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                string hyphens = new string('-', hyphensLRCount);

                Console.WriteLine($"{hyphens}\\{new string('.', width - 1)}\\");

                hyphensLRCount++;
            }

            int dotsCount = (width - 6) / 2;
            string dots = new string('.', dotsCount);

            Console.WriteLine($"{new string('-', hyphensLRCount)}\\{dots}MERRY{dots}\\");
            hyphensLRCount++;
            Console.WriteLine($"{new string('-', hyphensLRCount)}\\{new string('.', width - 1)}\\");
            hyphensLRCount++;
            Console.WriteLine($"{new string('-', hyphensLRCount)}\\{dots}X-MAS{dots}\\");
            hyphensLRCount++;

            for (int i = 1; i <= Math.Ceiling(n / 2.0) - 1; i++)
            {
                Console.WriteLine($"{new string('-', hyphensLRCount)}\\{new string('.', width - 1)}\\");

                hyphensLRCount++;
            }

            // Last line
            Console.WriteLine($"{new string('-', hyphensLRCount)}\\{new string('_', width - 1)})");
        }
    }
}