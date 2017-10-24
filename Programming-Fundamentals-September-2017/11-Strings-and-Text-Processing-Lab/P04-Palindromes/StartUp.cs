namespace P04_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputToWords = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var palindromes = new HashSet<string>();

            foreach (var word in inputToWords)
            {
                if (IsWordPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", palindromes
                .OrderBy(n => n)));
        }

        public static bool IsWordPalindrome(string word)
        {
            if (word.Length == 1) return true;

            var builder = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                builder.Append(word[i]);
            }

            string wordReversed = builder.ToString();

            int test = string.Compare(wordReversed, word, false);

            return test == 0;
        }
    }
}