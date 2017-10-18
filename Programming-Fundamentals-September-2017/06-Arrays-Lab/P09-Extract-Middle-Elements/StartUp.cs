namespace P09_Extract_Middle_Elements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            ExtractMiddleElements(array);
        }

        public static void ExtractMiddleElements(long[] array)
        {
            int n = array.Length;

            if (n == 1)
            {
                Console.WriteLine($"{{ {string.Join("", array)} }}");
            }
            else if (n % 2 == 0)
            {
                long[] middleElementsEven = new long[2];
                middleElementsEven[0] = array[n / 2 - 1];
                middleElementsEven[1] = array[n / 2];

                Console.WriteLine($"{{ {string.Join(", ", middleElementsEven)} }}");
            }
            else
            {
                long[] middleElementsOdd = new long[3];
                middleElementsOdd[0] = array[n / 2 - 1];
                middleElementsOdd[1] = array[n / 2];
                middleElementsOdd[2] = array[n / 2 + 1];

                Console.WriteLine($"{{ {string.Join(", ", middleElementsOdd)} }}");
            }
        }
    }
}