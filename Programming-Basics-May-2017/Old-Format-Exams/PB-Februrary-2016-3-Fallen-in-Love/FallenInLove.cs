using System;

namespace PB_Februrary_2016_3_Fallen_in_Love
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (2 * n) + (2 * n) + 6;

            // First row
            Console.WriteLine("##{0}##{0}##", new string ('.', (width - 6) / 2));

            // Next n - 1 rows
            int wavesLRCount = 1;
            string wavesLR = new string('~', wavesLRCount);
            int dotsLRCount = (n * 2) - 2;
            string dotsLR = new string('.', dotsLRCount);
            int dotsMidCount = 2;
            string dotsMid = new string('.', dotsMidCount);

            for (int row = 1; row <= n - 1; row++)
            {
                wavesLR = new string('~', wavesLRCount);
                dotsLR = new string('.', dotsLRCount);
                dotsMid = new string('.', dotsMidCount);

                Console.WriteLine($"#{wavesLR}#{dotsLR}#{dotsMid}#{dotsLR}#{wavesLR}#");

                wavesLRCount++;
                dotsLRCount -= 2;
                dotsMidCount += 2;
            }

            // Next n rows
            dotsLRCount = 1;
            for (int row = 1; row <= n; row++)
            {
                wavesLR = new string('~', wavesLRCount);
                dotsLR = new string('.', dotsLRCount);
                dotsMid = new string('.', dotsMidCount);

                Console.WriteLine($"{dotsLR}#{wavesLR}#{dotsMid}#{wavesLR}#{dotsLR}");

                dotsLRCount += 2;
                wavesLRCount--;
                dotsMidCount -= 2;
            }

            // Last n + 1 rows

            Console.WriteLine("{0}####{0}", new string('.', (width - 4) / 2));
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine("{0}##{0}", new string('.', (width - 2) / 2));
            }
        }
    }
}