namespace P04_Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine()
                .Split(new char[]
                { ',', ';', ':', '.', '!', '(', ')', '\"', '/', '\\', '[', ']' , '\'', ' '},
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                string currentWord = text[i];
                int lowerCaseLetters = 0;
                int upperCaseLetters = 0;

                foreach (char letter in currentWord)
                {
                    if (letter >= 65 && letter <= 90)
                    {
                        upperCaseLetters++;
                    }
                    else if (letter >= 97 && letter <= 122)
                    {
                        lowerCaseLetters++;
                    }
                }

                if (lowerCaseLetters == currentWord.Length)
                {
                    lowerCaseWords.Add(currentWord);
                }
                else if (upperCaseLetters == currentWord.Length)
                {
                    upperCaseWords.Add(currentWord);
                }
                else
                {
                    mixedCaseWords.Add(currentWord);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}