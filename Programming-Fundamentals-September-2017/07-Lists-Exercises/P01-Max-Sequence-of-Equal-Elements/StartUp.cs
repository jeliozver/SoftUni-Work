namespace P01_Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int currentStart = 0;
            int currentLenght = 1;
            int bestStart = 0;
            int bestLenght = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLenght++;
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }

                if (currentLenght > bestLenght)
                {
                    bestStart = currentStart;
                    bestLenght = currentLenght;
                }
            }

            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();
        }
    }
}