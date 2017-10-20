namespace P04_Max_Sequence_of_Equal_Elements
{
    using System.IO;
    using System.Linq;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = "Input.txt";

            int[] numbers = File.ReadAllText(input)
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentStart = 0;
            int currentLenght = 1;
            int bestStart = 0;
            int bestLenght = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[currentStart])
                {
                    currentLenght++;
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }

                if (currentLenght <= bestLenght) continue;
                bestStart = currentStart;
                bestLenght = currentLenght;
            }

            string result = string.Empty;

            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                result += $"{numbers[i]} ";
            }

            File.WriteAllText("Output.txt", result.TrimEnd());
        }
    }
}