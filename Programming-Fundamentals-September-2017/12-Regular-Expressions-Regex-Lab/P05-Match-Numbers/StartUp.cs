namespace P05_Match_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string numbers = Console.ReadLine();

            var numbersMatches = Regex.Matches(numbers, pattern);

            foreach (Match number in numbersMatches)
            {
                Console.Write($"{number.Value} ");
            }

            Console.WriteLine();
        }
    }
}