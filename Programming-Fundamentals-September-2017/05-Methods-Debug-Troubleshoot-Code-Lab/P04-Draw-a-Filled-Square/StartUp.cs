namespace P04_Draw_a_Filled_Square
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);
            PrintMiddleRow(n);
            PrintHeaderFooter(n);
        }

        public static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRow(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}