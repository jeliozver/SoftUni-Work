namespace P10_Pairs_by_Difference
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

            int difference = int.Parse(Console.ReadLine());

            int elementsWithDifference = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] - numbers[j] == difference)
                    {
                        elementsWithDifference++;
                    }
                }
            }

            Console.WriteLine(elementsWithDifference);
        }
    }
}