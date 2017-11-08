namespace P03_Target_Multiplier
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
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

            int[] targetCell = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int targetRow = targetCell[0];
            int targetCol = targetCell[1];

            int startRow = targetRow - 1;
            int endRow = targetRow + 1;
            int startCol = targetCol - 1;
            int endCol = targetCol + 1;

            long sumOfNeighbours = 0L;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    sumOfNeighbours += matrix[row, col];
                }
            }

            long originalCellValue = matrix[targetRow, targetCol];
            sumOfNeighbours -= originalCellValue;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    if (row == targetRow && col == targetCol)
                    {
                        matrix[row, col] *= sumOfNeighbours;
                    }
                    else
                    {
                        matrix[row, col] *= originalCellValue;
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