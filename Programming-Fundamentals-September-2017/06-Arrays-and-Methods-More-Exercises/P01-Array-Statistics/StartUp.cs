namespace P01_Array_Statistics
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine($"Min = {GetMinValue(numbers)}");
            Console.WriteLine($"Max = {GetMaxValue(numbers)}");
            Console.WriteLine($"Sum = {GetSumOfElements(numbers)}");
            Console.WriteLine($"Average = {GetAverageValue(numbers)}");

        }

        public static double GetMaxValue(int[] array)
        {
            int maxValue = int.MinValue;

            foreach (int element in array)
            {
                maxValue = Math.Max(element, maxValue);
            }

            return maxValue;
        }

        public static double GetMinValue(int[] array)
        {
            int minValue = int.MaxValue;

            foreach (int element in array)
            {
                minValue = Math.Min(element, minValue);
            }

            return minValue;
        }

        public static double GetSumOfElements(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }

            return sum;
        }

        public static double GetAverageValue(int[] array)
        {
            double sum = GetSumOfElements(array);
            double average = sum / array.Length;
            return average;
        }
    }
}