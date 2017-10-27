namespace P05_Only_Letters
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string message = Console.ReadLine();

            string numLetterMatch = @"([0-9]+)([A-Za-z])";

            var matches = Regex.Matches(message, numLetterMatch);

            foreach (Match match in matches)
            {
                message = Regex.Replace(message,
                    match.Groups[1].Value,
                    match.Groups[2].Value);
            }

            Console.WriteLine(message);
        }
    }
}