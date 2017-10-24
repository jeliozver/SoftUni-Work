namespace P04_Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b(\d{2})(.|\/|-)([A-Z][a-z]{2})\2(\d{4})\b";

            string text = Console.ReadLine();

            var dateMatches = Regex.Matches(text, pattern);

            foreach (Match date in dateMatches)
            {
                var day = date.Groups[1];
                var month = date.Groups[3];
                var year = date.Groups[4];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}