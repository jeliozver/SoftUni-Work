using System;

namespace PB_January_2016_3_Illuminati_Lock
{
    class IlluminatiLock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = n + 1;
            int width = 3 * n;

            // First two rows
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
            Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));

            // Base Top
            int dotLRCount = n - 4;
            int dotLRMidCount = 2;
            int dotMidCount = n - 2;

            for (int row = 1; row <= (height - 4) / 2; row++)
            {
                string dotLR = new string('.', dotLRCount);
                string dotLRMid = new string('.', dotLRMidCount);
                string dotMid = new string('.', dotMidCount);

                Console.WriteLine($"{dotLR}##{dotLRMid}#{dotMid}#{dotLRMid}##{dotLR}");

                dotLRCount -= 2;
                dotLRMidCount += 2;
            }

            // Base Bottom
            dotLRCount = 1;
            dotLRMidCount = n - 3;

            for (int row = 1; row <= (height - 4) / 2; row++)
            {
                string dotLR = new string('.', dotLRCount);
                string dotLRMid = new string('.', dotLRMidCount);
                string dotMid = new string('.', dotMidCount);

                Console.WriteLine($"{dotLR}##{dotLRMid}#{dotMid}#{dotLRMid}##{dotLR}");

                dotLRCount += 2;
                dotLRMidCount -= 2;
            }

            // Last two rows
            Console.WriteLine("{0}###{0}###{0}", new string('.', n - 2));
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}