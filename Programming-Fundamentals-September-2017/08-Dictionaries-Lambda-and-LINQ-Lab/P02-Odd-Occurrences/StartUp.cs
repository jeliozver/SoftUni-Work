namespace P02_Odd_Occurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string[] wordsList = Console.ReadLine()
                .ToLower()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in wordsList)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }

                wordCount[word]++;
            }

            List<string> result = new List<string>();

            foreach (var count in wordCount)
            {
                if (count.Value % 2 != 0)
                {
                    result.Add(count.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}