namespace P03_Search_for_a_Number
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

            int[] arguments = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            int elementsToTake = arguments[0];
            int elementsToDelete = arguments[1];
            int searchNumber = arguments[2];

            for (int i = 0; i < elementsToTake; i++)
            {
                result.Add(numbers[i]);
            }

            result.RemoveRange(0, elementsToDelete);

            foreach (int t in result)
            {
                if (t == searchNumber)
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }

            Console.WriteLine("NO!");
        }
    }
}