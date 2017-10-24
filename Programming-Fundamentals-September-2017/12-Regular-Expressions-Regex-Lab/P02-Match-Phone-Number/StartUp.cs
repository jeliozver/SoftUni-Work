namespace P02_Match_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"(\b|)\+359(\s|-)2\2\d{3}\2\d{4}\b";

            string phoneNumbers = Console.ReadLine();

            var phoneMatches = Regex.Matches(phoneNumbers, pattern);

            var validPhones = phoneMatches
                .Cast<Match>()
                .Select(vp => vp.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", validPhones));
        }
    }
}