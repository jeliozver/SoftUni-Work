namespace P03_Fold_and_Sum
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

            int quarter = numbers.Length / 4; // Lenght of one quarter of the array

            int[] leftArray = ExtractPartOfArray(numbers, 0, quarter);
            int[] middleArray = ExtractPartOfArray(numbers, quarter, quarter * 2);
            int[] rightArray = ExtractPartOfArray(numbers, quarter * 3, quarter);
            int[] sumArray = new int[quarter * 2];

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] leftRightArray = leftArray.Concat(rightArray).ToArray();

            for (int i = 0; i < quarter * 2; i++)
            {
                sumArray[i] = leftRightArray[i] + middleArray[i];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static int[] ExtractPartOfArray(int[] array, int startIndex, int endIndex)
        {
            int[] extractedArray = new int[endIndex];

            for (int i = 0; i < endIndex; i++)
            {
                extractedArray[i] = array[startIndex];
                startIndex++;
            }

            return extractedArray;
        }
    }
}