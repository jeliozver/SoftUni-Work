using System;

namespace Perfect_Diamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int spaceCount = n - 1;
            string space = new string(' ', spaceCount);

            int hyphenStarCount = 0;
            string hyphenStar = newStr("-*", hyphenStarCount);

            for (int i = 1; i <= n; i++)
            {
                space = new string(' ', spaceCount);
                hyphenStar = newStr("-*", hyphenStarCount);
                Console.WriteLine($"{space}*{hyphenStar}");

                hyphenStarCount++;
                spaceCount--;
            }

            spaceCount = 1;
            hyphenStarCount = n - 2;

            for (int i = 1; i <= n - 1; i++)
            {
                space = new string(' ', spaceCount);
                hyphenStar = newStr("-*", hyphenStarCount);
                Console.WriteLine($"{space}*{hyphenStar}");

                hyphenStarCount--;
                spaceCount++;
            }

        }

        private static string newStr(string str, int count)
        {
            string body = "";

            for (int i = 0; i < count; i++)
            {
                body = body + str;
            }
            return body;
        }
    }
}
