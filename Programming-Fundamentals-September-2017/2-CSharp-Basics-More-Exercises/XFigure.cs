using System;

namespace X_Figure
{
    class XFigure
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spacesLRCount = 0;
            string spacesLR = new string(' ', spacesLRCount);
            int spacesMidCount = n - 2;
            string spacesMid = new string(' ', spacesMidCount);

            // Top
            for (int row = 1; row <= n / 2; row++)
            {
                spacesLR = new string(' ', spacesLRCount);
                spacesMid = new string(' ', spacesMidCount);

                Console.WriteLine($"{spacesLR}x{spacesMid}x{spacesLR}");

                spacesMidCount -= 2;
                spacesLRCount++;
            }

            // Middle line
            spacesLRCount = n / 2;
            spacesLR = new string(' ', spacesLRCount);
            Console.WriteLine($"{spacesLR}x{spacesLR}");

            // Bottom
            spacesLRCount = (n / 2) - 1;
            spacesMidCount = 1;
            for (int row = 1; row <= n / 2; row++)
            {

                spacesLR = new string(' ', spacesLRCount);
                spacesMid = new string(' ', spacesMidCount);
   
                Console.WriteLine($"{spacesLR}x{spacesMid}x{spacesLR}");

                spacesLRCount--;
                spacesMidCount += 2;
            }
        }
    }
}