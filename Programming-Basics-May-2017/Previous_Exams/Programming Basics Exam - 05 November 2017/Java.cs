namespace PB_November_2017_5_Java
{
    using System;

    public class Java
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 6;

            PrintTop(n, width);
            PrintHandleHeaderFooter(width);
            PrintHandle(n, width);
            PrintHandleHeaderFooter(width);
            PrintBase(n, width);
            PrintPad(width, n);
        }

        public static void PrintTop(int n, int width)
        {
            string spaces = new string(' ', n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{spaces}~ ~ ~");
            }
        }

        public static void PrintHandleHeaderFooter(int width)
        {
            Console.WriteLine("{0}", new string('=', width - 1));
        }

        public static void PrintHandle(int n, int width)
        {
            int wavesCount = n * 2 + 4;
            int spacesCount = width - wavesCount - 3;
            string spaces = new string(' ', spacesCount);
            string waves = new string('~', wavesCount);

      
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == n / 2)
                {
                    string javaRowWaves = new string('~', n);
                    Console.WriteLine($"|{javaRowWaves}JAVA{javaRowWaves}|{spaces}|");
                }
                else
                {
                    Console.WriteLine($"|{waves}|{spaces}|");
                }
            }
        }

        public static void PrintBase(int n, int width)
        {
            int spacesCount = 0;
            int atSignsCount = n * 2 + 4;

            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', spacesCount);
                string atSigns = new string('@', atSignsCount);

                Console.WriteLine($"{spaces}\\{atSigns}/");

                spacesCount++;
                atSignsCount -= 2;
            }
        }

        public static void PrintPad(int width, int n)
        {
            Console.WriteLine("{0}", new string('=', width - n));
        }
    }
}