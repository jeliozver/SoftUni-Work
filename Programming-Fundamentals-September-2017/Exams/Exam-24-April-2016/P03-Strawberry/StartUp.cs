namespace P03_Strawberry
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintLeaves(n);
            PrintBaseHeader(n);
            PrintBaseFooter(n);
        }

        private static void PrintLeaves(int n)
        {
            int dashesLRCount = 0;
            int dashesMidCount = n;

            for (int i = 0; i < n / 2; i++)
            {
                string dashesLR = new string('-', dashesLRCount);
                string dashesMid = new string('-', dashesMidCount);

                Console.WriteLine($"{dashesLR}\\{dashesMid}|{dashesMid}/{dashesLR}");

                dashesLRCount += 2;
                dashesMidCount -= 2;
            }
        }

        private static void PrintBaseHeader(int n)
        {
            int dashesLRCount = n;
            int dotsCount = 1;

            for (int i = 0; i < n / 2 + 2; i++)
            {
                if (dashesLRCount < 0)
                {
                    dashesLRCount = 0;
                }

                if (i == n / 2 + 1)
                {
                    dotsCount -= 2;
                }

                string dashesLR = new string('-', dashesLRCount);
                string dots = new string('.', dotsCount);

                Console.WriteLine($"{dashesLR}#{dots}#{dashesLR}");

                dashesLRCount -= 2;
                dotsCount += 4;
            }
        }

        private static void PrintBaseFooter(int n)
        {
            int dashesLRCount = 1;
            int dotsCount = n * 2 - 1;

            for (int i = 0; i < n; i++)
            {
                string dashesLR = new string('-', dashesLRCount);
                string dots = new string('.', dotsCount);

                Console.WriteLine($"{dashesLR}#{dots}#{dashesLR}");

                dashesLRCount++;
                dotsCount -= 2;
            }
        }
    }
}