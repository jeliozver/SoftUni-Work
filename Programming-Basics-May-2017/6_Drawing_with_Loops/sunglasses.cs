using System;

namespace Sunglasses
{
    class sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string stars = new string('*', 2 * n);
            string spaces = new string(' ', n);

            string slashes = new string('/', 2 * n - 2);
            string vbars = new string('|', n);

            // Top 
            Console.WriteLine($"{stars}{spaces}{stars}");

            // Middle
            for (int i = 0; i < n - 2; i++)
            {
                if (i == ((n - 1) / 2) - 1)
                {
                    Console.WriteLine($"*{slashes}*{vbars}*{slashes}*");
                }
                else
                {
                    Console.WriteLine($"*{slashes}*{spaces}*{slashes}*");
                }
            }

            // Bottom
            Console.WriteLine($"{stars}{spaces}{stars}");
        }
    }
}