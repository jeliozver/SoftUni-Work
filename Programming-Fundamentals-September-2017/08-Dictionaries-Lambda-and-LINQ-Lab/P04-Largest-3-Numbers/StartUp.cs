namespace P04_Largest_3_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var result = numbers.OrderByDescending(n => n).Take(3);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}