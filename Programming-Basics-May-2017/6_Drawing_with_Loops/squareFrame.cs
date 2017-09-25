using System;

namespace Square_Frame
{
    class squareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("+");
                return;
            }

            for (int firstRow = 0; firstRow < 1; firstRow++)
            {
                Console.Write("+");
                for (int firstCol = 0; firstCol < n - 2; firstCol++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }

            for (int middleRows = 0; middleRows < n - 2; middleRows++)
            {
                Console.Write("|");
                for (int middleCols = 0; middleCols < n - 2; middleCols++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            for (int lastRow = 0; lastRow < 1; lastRow++)
            {
                Console.Write("+");
                for (int lastCol = 0; lastCol < n - 2; lastCol++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" +");
            }
        }
    }
}
