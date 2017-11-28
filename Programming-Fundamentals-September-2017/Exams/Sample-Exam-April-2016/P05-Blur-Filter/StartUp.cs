namespace P05_Blur_Filter
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int blurAmount = int.Parse(Console.ReadLine());

            int[] dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            long[,] matrix = new long[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            int[] blurCoordinates = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int blurRow = blurCoordinates[0];
            int blurCol = blurCoordinates[1];

            int startRow = blurRow - 1;
            int endRow = blurRow + 1;
            int startCol = blurCol - 1;
            int endCol = blurCol + 1;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    try
                    {
                        matrix[row, col] += blurAmount;
                    }
                    catch (Exception)
                    {
                       
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
