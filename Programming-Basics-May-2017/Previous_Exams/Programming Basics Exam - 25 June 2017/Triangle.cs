using System;

namespace PB_June_2017_5_Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (4 * n) + 1;
            int height = (2 * n) + 1;

            int dotsLRCount = 1;
            int hashTagsLRCount = (n * 2) - 1;
            int spacesCount = 1;

            string dotsLR = new string('.', dotsLRCount);
            string hashTagsLR = new string('#', hashTagsLRCount);
            string spaces = new string(' ', spacesCount);

            // First row
            Console.WriteLine("{0}", new string('#', width));

            // Triangle top
            for (int row = 1; row <= n; row++)
            {
                dotsLR = new string('.', dotsLRCount);
                hashTagsLR = new string('#', hashTagsLRCount);
                spaces = new string(' ', spacesCount);

                if (row == (n / 2) + 1)
                {
                    int spacesLRCount = (width - 3) - (hashTagsLRCount * 2) - (dotsLRCount * 2);
                    string spacesLR = new string(' ', spacesLRCount / 2);
                    Console.WriteLine($"{dotsLR}{hashTagsLR}{spacesLR}(@){spacesLR}{hashTagsLR}{dotsLR}");
                }
                else
                {
                    Console.WriteLine($"{dotsLR}{hashTagsLR}{spaces}{hashTagsLR}{dotsLR}");
                }

                dotsLRCount++;
                spacesCount += 2;
                hashTagsLRCount -= 2;
            }

            // Triangle bottom
            hashTagsLRCount = width - (dotsLRCount * 2);

            for (int row = 1; row <= n; row++)
            {
                dotsLR = new string('.', dotsLRCount);
                hashTagsLR = new string('#', hashTagsLRCount);

                Console.WriteLine($"{dotsLR}{hashTagsLR}{dotsLR}");

                dotsLRCount++;
                hashTagsLRCount -= 2;
            }
        }
    }
}