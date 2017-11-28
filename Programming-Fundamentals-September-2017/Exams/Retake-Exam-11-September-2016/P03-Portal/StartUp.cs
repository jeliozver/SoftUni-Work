namespace P03_Portal
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int roomSize = int.Parse(Console.ReadLine());

            char[][] testRoom = new char[roomSize][];
            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < roomSize; i++)
            {
                char[] cellsInfo = Console.ReadLine()
                    .ToCharArray();
                
                testRoom[i] = cellsInfo;
            }

            for (int i = 0; i < testRoom.Length; i++)
            {
                for (int j = 0; j < testRoom[i].Length; j++)
                {
                    if (testRoom[i][j] != 'S') continue;
                    startRow = i;
                    startCol = j;
                    break;
                }
            }

            int currentRow = startRow;
            int currentCol = startCol;
            char currentPos = testRoom[currentRow][currentCol];
            int turns = 0;

            char[] directions = Console.ReadLine()
                .ToCharArray();

            foreach (char direction in directions)
            {
                turns++;
                char currentDirection = direction;

                switch (currentDirection)
                {
                    case 'R':
                        right:
                        currentCol++;

                        if (currentCol == testRoom[currentRow].Length)
                        {
                            currentCol = 0;
                        }

                        try
                        {
                            currentPos = testRoom[currentRow][currentCol];
                        }
                        catch (Exception)
                        {
                            goto right;
                        }
                        break;
                    case 'L':
                        left:
                        currentCol--;

                        if (currentCol == -1)
                        {
                            currentCol = testRoom[currentRow].Length;
                        }

                        try
                        {
                            currentPos = testRoom[currentRow][currentCol];
                        }
                        catch (Exception)
                        {
                            goto left;
                        }
                        break;
                    case 'U':
                        upper:
                        currentRow--;
                        if (currentRow == -1)
                        {
                            currentRow = testRoom.Length;
                        }

                        try
                        {
                            currentPos = testRoom[currentRow][currentCol];
                        }
                        catch (Exception)
                        {
                            goto  upper;
                        }
                        break;
                    case 'D':
                        lower:
                        currentRow++;
                        if (currentRow == testRoom.Length)
                        {
                            currentRow = 0;
                        }

                        try
                        {
                            currentPos = testRoom[currentRow][currentCol];
                        }
                        catch (Exception)
                        {
                            goto lower;
                        }
                        break;
                }

                if (currentPos != 'E') continue;
                Console.WriteLine($"Experiment successful. {turns} turns required.");
                return;
            }

            Console.WriteLine($"Robot stuck at {currentRow} {currentCol}. Experiment failed.");
        }
    }
}
