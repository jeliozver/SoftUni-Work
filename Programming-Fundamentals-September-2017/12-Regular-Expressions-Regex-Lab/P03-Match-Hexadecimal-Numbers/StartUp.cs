namespace P03_Match_Hexadecimal_Numbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string text = Console.ReadLine();

            var hexMatches = Regex.Matches(text, pattern);

            var validHex = hexMatches
                .Cast<Match>()
                .Select(hex => hex.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", validHex));
        }
    }
}