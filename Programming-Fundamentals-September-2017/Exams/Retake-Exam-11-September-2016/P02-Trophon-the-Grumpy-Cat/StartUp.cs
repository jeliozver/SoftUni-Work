namespace P02_Trophon_the_Grumpy_Cat
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] priceRatings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string itemsType = Console.ReadLine();
            string ratingsType = Console.ReadLine();

            int[] left = priceRatings.Take(entryPoint).ToArray();
            int[] right = priceRatings.Skip(entryPoint + 1).ToArray();
            int entryPointValue = priceRatings[entryPoint];

            if (itemsType == "cheap")
            {
                left = left.Where(p => p < entryPointValue).ToArray();
                right = right.Where(p => p < entryPointValue).ToArray();
            }
            else
            {
                left = left.Where(p => p >= entryPointValue).ToArray();
                right = right.Where(p => p >= entryPointValue).ToArray();
            }

            string result = string.Empty;

            if (ratingsType == "positive")
            {
                left = left.Where(p => p > 0).ToArray();
                right = right.Where(p => p > 0).ToArray();
            }
            else if (ratingsType == "negative")
            {
                left = left.Where(p => p < 0).ToArray();
                right = right.Where(p => p < 0).ToArray();
            }


            long leftSum = 0;

            for (int i = 0; i < left.Length; i++)
            {
                leftSum += left[i];
            }

            long rightSum = 0;

            for (int i = 0; i < right.Length; i++)
            {
                rightSum += right[i];
            }

            if (leftSum >= rightSum)
            {
                result = $"Left - {leftSum}";
            }
            else
            {
                result = $"Right - {rightSum}";
            }

            Console.WriteLine(result);
        }
    }
}