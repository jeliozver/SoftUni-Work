namespace P03_Dress_Pattern
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int width = 12 * n + 2;
            int underscoresCount = (width - 2) / 3;

            // First line
            Console.WriteLine("{0}.{0}.{0}", new string('_', underscoresCount));

            int starsCount = 2;
            underscoresCount -= 2;

            // Sleeves
            for (int i = 0; i <= n * 2 - 1; i++)
            {
                string stars = new string('*', starsCount);
                string underscores = new string('_', underscoresCount);

                Console.WriteLine($"{underscores}.{stars}.{underscores}.{stars}.{underscores}");

                underscoresCount -= 2;
                starsCount += 3;
            }

            // Dress base
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(".{0}.", new string('*', width - 2));
            }

            // Line before belt
            Console.WriteLine("{0}{1}{0}"
                , new string('.', n * 3)
                , new string('*', width - n * 6));

            // Belt
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}"
                    , new string('_', n * 3)
                    , new string('o', width - n * 6));
            }

            underscoresCount = n * 3;
            starsCount = width - n * 6 - 2;

            // Bottom lines
            for (int i = 0; i < 3 * n; i++)
            {
                string stars = new string('*', starsCount);
                string underscores = new string('_', underscoresCount);

                Console.WriteLine($"{underscores}.{stars}.{underscores}");

                underscoresCount--;
                starsCount += 2;
            }

            // Last line
            Console.WriteLine("{0}", new string('.', width));
        }
    }
}