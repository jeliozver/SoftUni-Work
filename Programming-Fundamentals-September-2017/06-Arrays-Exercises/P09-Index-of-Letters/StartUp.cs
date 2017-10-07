namespace P09_Index_of_Letters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 'a'}");
            }
        }
    }
}