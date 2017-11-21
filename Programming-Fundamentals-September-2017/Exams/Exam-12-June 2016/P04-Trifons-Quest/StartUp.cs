namespace P04_Trifons_Quest
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            long health = long.Parse(Console.ReadLine());

            if (health == 0)
            {
                Console.WriteLine($"Died at: [{0}, {0}]");
                return;
            }

            int[] rowsCols = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string map = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = map[col];
                }
            }

            bool isDown = true;
            int turns = 0;

            for (int i = 0; i < cols; i++)
            {
                if (isDown)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        char currentCell = matrix[j, i];

                        switch (currentCell)
                        {
                            case 'F':
                                health -= turns / 2;
                                break;
                            case 'H':
                                health += turns / 3;
                                break;
                            case 'T':
                                turns += 2;
                                break;
                        }

                        if (health <= 0)
                        {
                            Console.WriteLine($"Died at: [{j}, {i}]");
                            return;
                        }

                        turns++;
                    }

                    isDown = false;
                }
                else
                {
                    for (int j = rows - 1; j >= 0; j--)
                    {
                        char currentCell = matrix[j, i];

                        switch (currentCell)
                        {
                            case 'F':
                                health -= turns / 2;
                                break;
                            case 'H':
                                health += turns / 3;
                                break;
                            case 'T':
                                turns += 2;
                                break;
                        }

                        if (health <= 0)
                        {
                            Console.WriteLine($"Died at: [{j}, {i}]");
                            return;
                        }

                        turns++;
                    }

                    isDown = true;
                }
            }

            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Turns: {turns}");
        }
    }
}
