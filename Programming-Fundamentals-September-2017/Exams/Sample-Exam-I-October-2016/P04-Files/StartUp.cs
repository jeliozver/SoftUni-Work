namespace P04_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());

            var messages = new List<string>();

            for (int i = 0; i < messagesCount; i++)
            {
                string currentInput = Console.ReadLine();

                messages.Add(currentInput);
            }

            var result = new Dictionary<string, long>();

            string filter = Console.ReadLine();
            var filterTokens = Regex.Split(filter, " in ");
            string filterExt = "." + filterTokens[0];
            string filterRoot = filterTokens[1] + @"\";

            foreach (var f in messages)
            {
                var filePlusSize = f.Split(';');
                var size = long.Parse(filePlusSize[1]);
                var path = filePlusSize[0];

                if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var tokens = path.Split('\\');
                    var fileName = tokens[tokens.Length - 1];
                    result[fileName] = size;
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var dir in result.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{dir.Key} - {dir.Value} KB");
                }
            }
        }
    }
}