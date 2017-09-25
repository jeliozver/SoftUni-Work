using System;

namespace PB_Aug_2016_5_Axe
{
    class axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starsCount = 0;
            string star = new string('*', starsCount);

            int hyphenLeftCount = n * 3;
            int hyphenMidCount = 1;
            int hyphenRightCount = ( n * 5) - (n * 3) - 2;

            string hyphenLeft = new string('-', hyphenLeftCount);
            string hyphenMid = new string('-', hyphenMidCount);
            string hyphenRight = new string('-', hyphenRightCount);

            // Top
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    hyphenLeft = new string('-', hyphenLeftCount);
                    Console.WriteLine($"{hyphenLeft}**{hyphenRight}");
                    hyphenRightCount--;
                }
                else
                { 
                    hyphenLeft = new string('-', hyphenLeftCount);
                    hyphenMid = new string('-', hyphenMidCount);
                    hyphenRight = new string('-', hyphenRightCount);

                    Console.WriteLine($"{hyphenLeft}*{hyphenMid}*{hyphenRight}");
                    hyphenMidCount++;
                    hyphenRightCount--;
                }
            }

            // Handle
            for (int i = 0; i < n / 2; i++)
            {
                starsCount = n * 3;
                star = new string('*', starsCount);
                Console.WriteLine($"{star}*{hyphenMid}*{hyphenRight}");
            }

            // Bottom
            hyphenMidCount--;
            hyphenRightCount++;
            for (int i = 0; i < n / 2; i++)
            {
                if (i == n / 2 - 1)
                {
                    hyphenLeft = new string('-', hyphenLeftCount);
                    star = new string('*', hyphenMidCount + 2);
                    hyphenRight = new string('-', hyphenRightCount);

                    Console.WriteLine($"{hyphenLeft}{star}{hyphenRight}");
                }
                else
                { 
                    hyphenLeft = new string('-', hyphenLeftCount);
                    hyphenMid = new string('-', hyphenMidCount);
                    hyphenRight = new string('-', hyphenRightCount);

                    hyphenLeftCount--;
                    hyphenMidCount += 2;
                    hyphenRightCount--;

                    Console.WriteLine($"{hyphenLeft}*{hyphenMid}*{hyphenRight}");
                }
            }
        }
    }
}
