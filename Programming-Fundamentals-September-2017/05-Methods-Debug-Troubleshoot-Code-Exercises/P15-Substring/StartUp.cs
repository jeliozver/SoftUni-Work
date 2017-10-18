namespace P15_Substring
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int lettersToPrint = int.Parse(Console.ReadLine());

            Substring(text, lettersToPrint);
        }

        public static void Substring(string text, int lettersToPrint)
        {
            int matchLetter = 112; // ASCII Code of the letter 'p'
            bool hasMatch = false;
            string matchedString = string.Empty;

            for (int startIndex = 0; startIndex < text.Length; startIndex++)
            {
                if (text[startIndex] == (char)matchLetter)
                {
                    hasMatch = true;

                    int endIndex = lettersToPrint;

                    if (endIndex > text.Length)
                    {
                        endIndex = text.Length;
                    }

                    if (startIndex + endIndex + 1 > text.Length)
                    {
                        endIndex = text.Length - startIndex;
                        matchedString = text.Substring(startIndex, endIndex);
                    }
                    else
                    {
                        endIndex++;
                        matchedString = text.Substring(startIndex, endIndex);
                    }

                    Console.WriteLine(matchedString);
                    startIndex += lettersToPrint;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}