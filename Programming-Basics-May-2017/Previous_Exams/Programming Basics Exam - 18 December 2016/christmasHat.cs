using System;

namespace PB_Dec_2016_5_Christmas_Hat
{
    class christmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = (4 * n) + 1;

            int dotCount = width - 3;
            string dot = new string('.', dotCount / 2);

            int hyphenCount = 1;
            string hyphen = new string('-', hyphenCount);
            int starCount = width;
            string star = new string('*', starCount);

            // Top
            Console.WriteLine($"{dot}/|\u005C{dot}");
            Console.WriteLine($"{dot}\u005C|/{dot}");
            Console.WriteLine($"{dot}***{dot}");

            // Middle 
            dotCount--;
            for (int i = 0; i < 2 * n - 1; i++)
            {
                dot = new string('.', dotCount / 2);
                hyphen = new string('-', hyphenCount);

                Console.WriteLine($"{dot}*{hyphen}*{hyphen}*{dot}");

                dotCount -= 2;
                hyphenCount++;
            }

            // Bottom
            Console.WriteLine($"{star}");

            Console.Write("*");
            for (int i = 0; i <= 2 * n - 1; i++)
            {

                Console.Write($".*");
            }

            Console.WriteLine();
            Console.WriteLine($"{star}");
        }
    }
}
