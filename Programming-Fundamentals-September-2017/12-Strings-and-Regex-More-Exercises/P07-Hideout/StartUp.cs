namespace P07_Hideout
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] clues = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                char hideout = char.Parse(clues[0]);
                int minSearchCount = int.Parse(clues[1]);

                string hideoutPattern = $"[\\{hideout}]{{{minSearchCount},}}";

                if (!Regex.IsMatch(map, hideoutPattern)) continue;

                var match = Regex.Match(map, hideoutPattern);

                int hideoutSize = match.Length;
                string hideoutLook = match.Value;

                int hideoutIndex = map.IndexOf(hideoutLook, hideoutSize);

                Console.WriteLine($"Hideout found at index {hideoutIndex} and it is with size {hideoutSize}!");
                break;
            }
        }
    }
}