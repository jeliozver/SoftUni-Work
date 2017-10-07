namespace P07_Max_Sequence_of_Increasing_Elements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int currentStart = 0;
            int currentLenght = 1;
            int bestStart = 0;
            int bestLenght = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
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