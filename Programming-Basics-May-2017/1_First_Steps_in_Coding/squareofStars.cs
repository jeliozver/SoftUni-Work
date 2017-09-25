using System;

namespace SquareofStars
{
    class squareofStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                for (int b = 0; b < n - 2; b++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
