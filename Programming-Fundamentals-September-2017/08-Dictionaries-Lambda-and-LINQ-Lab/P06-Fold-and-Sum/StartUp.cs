namespace P06_Fold_and_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] left = new int[k];
            int[] middle = new int[k * 2];
            int[] right = new int[k];

            left = numbers.Take(k).Reverse().ToArray();
            right = numbers.Reverse().Take(k).ToArray();
            middle = numbers.Skip(k).Take(2 * k).ToArray();

            int[] joinLeftRight = left.Concat(right).ToArray();

            int[] result = joinLeftRight
                .Select((x, index) 
                => x + middle[index])
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}