namespace P04_Triple_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            long[] arrayOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            bool isSumFound = false;

            for (int a = 0; a < arrayOfIntegers.Length; a++)
            {
                for (int b = a + 1; b < arrayOfIntegers.Length; b++)
                {
                    long sum = arrayOfIntegers[a] + arrayOfIntegers[b];

                    if (arrayOfIntegers.Contains(sum))
                    {
                        isSumFound = true;
                        Console.WriteLine($"{arrayOfIntegers[a]} + {arrayOfIntegers[b]} == {sum}");
                    }
                }
            }

            if (!isSumFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}