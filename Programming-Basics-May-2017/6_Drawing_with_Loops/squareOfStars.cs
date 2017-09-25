using System;

namespace Square_of_Stars
{
    class squareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             
            for (int row = 0; row < n; row++)
            {
                Console.Write("*");
                for (int col = 0; col < n - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
