using System;

namespace PB_MarchM_2_2017_5_Hourglass
{
    class hourglass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                return;
            }

            int width = (2 * n) + 1;

            int dotsLRCount = 2;
            int monkeyCount = width - 2 - (dotsLRCount * 2);
            int spacesLRCount = 0;

            string dotsLR = new string('.', dotsLRCount);
            string monkey = new string('@', monkeyCount);
            string spacesLR = new string(' ', spacesLRCount);

            // First two rows
            Console.WriteLine(new string('*', width));
            Console.WriteLine(".*{0}*.", new string(' ', width - 4));
            // Hourglass top
            for (int i = 1; i <= n - 2; i++)
            {
                dotsLR = new string('.', dotsLRCount);
                monkey = new string('@', monkeyCount);
                Console.WriteLine($"{dotsLR}*{monkey}*{dotsLR}");

                dotsLRCount++;
                monkeyCount -= 2;
            }
            // Mid row
            Console.WriteLine("{0}*{0}", new string('.', (width - 1) / 2));
            // Hourglass bottom
            dotsLRCount--;
            for (int i = 1; i <= n - 2; i++)
            {
                dotsLR = new string('.', dotsLRCount);
                spacesLR = new string(' ', spacesLRCount);
                Console.WriteLine($"{dotsLR}*{spacesLR}@{spacesLR}*{dotsLR}");

                dotsLRCount--;
                spacesLRCount++;
            }
            // Last two rows
            Console.WriteLine(".*{0}*.", new string('@', width - 4));
            Console.WriteLine(new string('*', width));
        }
    }
}