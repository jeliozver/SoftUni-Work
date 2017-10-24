namespace P08_Letters_Change_Numbers_V2
{
    using System;
    using System.Linq;

    // This version will work even if they add a lot of extra letters before and after the number!

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0m;

            foreach (string word in input)
            {
                int fistLetterStartPos = GetLetterPosBeforeNum(word);
                char firstLetter = word[fistLetterStartPos];
                int firstLetterPos = firstLetter % 32;

                int numberLenght = GetNumberLenght(word, fistLetterStartPos + 1);
                string numAsString = new string(word
                    .Skip(fistLetterStartPos + 1)
                    .Take(numberLenght).ToArray());

                decimal number = decimal.Parse(numAsString);

                int secondLetterStartPos = 1 + fistLetterStartPos + numberLenght;
                char secondLetter = word[secondLetterStartPos];
                int secondLetterPos = secondLetter % 32;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= firstLetterPos;
                }
                else if (firstLetter >= 97 && firstLetter <= 122)
                {
                    number *= firstLetterPos;
                }

                if (secondLetter >= 65 && secondLetter <= 90)
                {
                    number -= secondLetterPos;
                }
                else if (secondLetter >= 97 && secondLetter <= 122)
                {
                    number += secondLetterPos;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }

        public static int GetLetterPosBeforeNum(string word)
        {
            int letterPos = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 48 && word[i] <= 57)
                {
                    letterPos = i - 1;
                    break;
                }
            }

            return letterPos;
        }

        public static int GetNumberLenght(string word, int startPos)
        {
            int numberLenght = 0;

            word = word.ToLower();

            for (int i = startPos; i < word.Length; i++)
            {
                if (word[i] >= 97 && word[i] <= 122)
                {
                    break;
                }

                numberLenght++;
            }

            return numberLenght;
        }
    }
}