using System;

namespace PB_August_2015_3_Striped_Towel
{
    class StripedTowel
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            double height = Math.Floor(width * 1.5);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if ((row + col) % 3 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}