namespace P04_Grab_and_Go
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

            int stopNumber = int.Parse(Console.ReadLine());
            bool isStopNumberFound = false;

            long sum = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == stopNumber)
                {
                   isStopNumberFound = true;
                     
                }
                if (isStopNumberFound)
                {
                    sum += numbers[i];
                }
            }

            if (isStopNumberFound)
            {
                Console.WriteLine(sum - stopNumber);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}