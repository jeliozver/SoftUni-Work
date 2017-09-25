using System;

namespace PB_NovM_2016_5_Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 3;

            // Top rows (n)
            int starsLRCount = 1;
            int hyphensCount = (width - 2) - (starsLRCount * 2);

            for (int topRows = 1; topRows <= n; topRows++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                   new string('*', starsLRCount),
                   new string('-', hyphensCount));

                starsLRCount++;
                hyphensCount -= 2;
            }

            // Mid rows (n / 3)
            int starsMidCount = n;
            starsLRCount = (width - 4 - starsMidCount) / 2;
            
            for (int midRow = 1; midRow <= n / 3; midRow++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",
                     new string('*', starsLRCount),
                     new string('*', starsMidCount));

                starsMidCount -= 2;
                starsLRCount++;
            }

            // Bottom rows (n)
            hyphensCount = 1;
            starsLRCount = (width - 2) - (hyphensCount * 2);
            
            for (int bottomRows = 1; bottomRows <= n; bottomRows++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', hyphensCount),
                    new string('*', starsLRCount));

                hyphensCount++;
                starsLRCount -= 2;
            }
        }
    }
}