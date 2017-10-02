namespace P17_Print_Part_of_ASCII_Table
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (char i = (char)start; i <= (char)end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}