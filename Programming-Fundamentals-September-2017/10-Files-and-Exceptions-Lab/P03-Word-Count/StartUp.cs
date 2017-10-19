namespace P03_Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string text = "Input.txt";
                string words = "Words.txt";

                string[] textToWords = File.ReadAllText(text)
                    .ToLower()
                    .Split(new[] { ' ', '-', ',', '.', '?', '!', '\r', '\n', '…' }
                        , StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string[] wordsLines = File.ReadAllText(words)
                    .ToLower()
                    .Split(new[] { ' ' }
                        , StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToArray();

                var wordsCount = new Dictionary<string, int>();

                foreach (var word in textToWords)
                {
                    foreach (var wordToSum in wordsLines)
                    {
                        if (word == wordToSum)
                        {
                            if (!wordsCount.ContainsKey(wordToSum))
                            {
                                wordsCount[wordToSum] = 0;
                            }

                            wordsCount[wordToSum]++;
                        }
                    }
                }

                var result = new List<string>();

                foreach (var word in wordsCount.OrderByDescending(n => n.Value))
                {
                    result.Add($"{word.Key} - {word.Value}");
                }

                File.WriteAllLines("Output.txt", result);
            }
            catch (Exception)
            {
                Console.WriteLine("Create Input.txt and Words.txt with test info");
                Console.ReadKey();
            }
        }
    }
}