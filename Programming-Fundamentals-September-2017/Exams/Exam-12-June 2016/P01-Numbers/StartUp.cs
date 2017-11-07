namespace P01_Numbers
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

            decimal sum = numbers.Sum();
            decimal average = sum / numbers.Length;

            numbers = numbers
                .Where(x => x > average)
                .OrderByDescending(x => x)
                .Take(5)
                .ToArray();

            if (numbers.Any())
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}