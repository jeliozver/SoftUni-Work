using System;

namespace PB_March_1_2017_5_SoftUni_Logo
{
    class softUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 12 * n - 5;
            int heigh = 4 * n - 2;

            int dotCount = width / 2;
            string dot = new string('.', dotCount);
            int hashtagCount = 0;
            string hashtag = new string('#', hashtagCount);

            // Top
            Console.WriteLine($"{dot}#{dot}");

            dotCount -= 3;
            hashtagCount = width - dotCount * 2;
            for (int i = 1; i <= (heigh) - 2 - (n - 2) - n; i++)
            {
                dot = new string('.', dotCount);
                hashtag = new string('#', hashtagCount);

                Console.WriteLine($"{dot}{hashtag}{dot}");

                dotCount -= 3;
                hashtagCount = width - dotCount * 2;
            }

            // Middle
            Console.WriteLine(hashtag = new string('#', width));
            dotCount += 2;
            hashtagCount -= 6;
            for (int i = 0; i < n - 2; i++)
            {
                dot = new string('.', dotCount);
                hashtag = new string('#', hashtagCount);

                Console.WriteLine($"|{dot}{hashtag}{dot}.");

                dotCount += 3;
                hashtagCount = width - dotCount * 2 - 2;
            }

            // Bottom
            for (int i = 1; i <= n; i++)
            {
                hashtagCount = n * 6 + 1;
                dotCount = ((12 * n - 6) - hashtagCount) / 2;
                hashtag = new string('#', hashtagCount);
                dot = new string('.', dotCount);

                if (i < n)
                {
                    Console.WriteLine($"|{dot}{hashtag}{dot}.");
                }
                else
                {
                    Console.WriteLine($"@{dot}{hashtag}{dot}.");
                }
            }
        }
    }
}
