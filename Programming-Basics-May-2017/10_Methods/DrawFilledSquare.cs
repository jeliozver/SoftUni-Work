using System;

namespace Draw_Filled_Square
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);
            PrintMiddleRow(n);
            PrintHeaderFooter(n);
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}