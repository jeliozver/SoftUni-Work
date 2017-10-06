namespace P07_Sum_Arrays
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            long[] arrayOne = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            long[] arrayTwo = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long longerArray = Math.Max(arrayOne.Length, arrayTwo.Length);
            long[] arraySum = new long[longerArray];

            for (int i = 0; i < longerArray; i++)
            {
                arraySum[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}