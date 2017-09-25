using System;

namespace PB_March_2_2016_5_Butterfly
{
    class butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string starsLR = new string('*', n - 2);
            string hyphensLR = new string('-', n - 2);
            string spacesLR = new string(' ', n - 1);

            // Top rows
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{starsLR}\\ /{starsLR}");
                }
                else
                {
                    Console.WriteLine($"{hyphensLR}\\ /{hyphensLR}");               
                }
            }

            // Mid row
            Console.WriteLine($"{spacesLR}@{spacesLR}");

            // Bottom rows
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{starsLR}/ \\{starsLR}");
                }
                else
                {
                    Console.WriteLine($"{hyphensLR}/ \\{hyphensLR}");
                }
            }
        }
    }
}
