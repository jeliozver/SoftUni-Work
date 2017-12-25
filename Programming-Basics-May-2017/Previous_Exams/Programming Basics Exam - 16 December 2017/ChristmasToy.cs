namespace PB_Dec_2017_5_Christmas_Toy
{
    using System;

    public class ChristmasToy
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;

            // First line
            int hyphensCount = (width - n) / 2;
            string hyphens = new string('-', hyphensCount);
            string stars = new string('*', n);
            Console.WriteLine($"{hyphens}{stars}{hyphens}");

            // Top
            int ampersandsCount = n + 2;
            int starsCount = 1;
            hyphensCount -= 2;

            for (int i = 0; i < n / 2; i++)
            {
                string ampersands = new string('&', ampersandsCount);
                hyphens = new string('-', hyphensCount);
                stars = new string('*', starsCount);

                Console.WriteLine($"{hyphens}{stars}{ampersands}{stars}{hyphens}");

                ampersandsCount += 2;
                starsCount++;
                hyphensCount -= 2;
            }

            starsCount = 2;
            hyphensCount++;
            int wavesCount = width - starsCount * 2 - hyphensCount * 2;

            string waves;
            stars = new string('*', starsCount);

            for (int i = 0; i < n / 2; i++)
            {
                waves = new string('~', wavesCount);
                hyphens = new string('-', hyphensCount);

                Console.WriteLine($"{hyphens}{stars}{waves}{stars}{hyphens}");

                hyphensCount--;
                wavesCount += 2;
            }

            // Mid line
            hyphensCount = n / 2;
            hyphens = new string('-', hyphensCount);
            string lines = new string('|', width - n - 2);
            Console.WriteLine($"{hyphens}*{lines}*{hyphens}");

            // Bottom
            wavesCount -= 2;
            for (int i = 0; i < n / 2; i++)
            {
                waves = new string('~', wavesCount);
                hyphens = new string('-', hyphensCount);

                Console.WriteLine($"{hyphens}{stars}{waves}{stars}{hyphens}");

                hyphensCount++;
                wavesCount -= 2;
            }

            starsCount = n / 2;
            ampersandsCount -= 2;

            for (int i = 0; i < n / 2; i++)
            {
                string ampersands = new string('&', ampersandsCount);
                hyphens = new string('-', hyphensCount);
                stars = new string('*', starsCount);

                Console.WriteLine($"{hyphens}{stars}{ampersands}{stars}{hyphens}");

                starsCount--;
                hyphensCount += 2;
                ampersandsCount -= 2;
            }

            // Last Line
            hyphensCount = (width - n) / 2;
            hyphens = new string('-', hyphensCount);
            stars = new string('*', n);
            Console.WriteLine($"{hyphens}{stars}{hyphens}");
        }
    }
}