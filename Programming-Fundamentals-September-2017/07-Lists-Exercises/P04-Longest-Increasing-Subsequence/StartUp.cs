namespace P04_Longest_Increasing_Subsequence
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

            GetLIS(numbers);
        }

        public static void GetLIS(int[] sequence)
        {
            if (sequence.Length == 1)
            {
                Console.WriteLine(sequence[0]);
                return;
            }

            string[] paths = new string[sequence.Length];
            int[] sizes = new int[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                sizes[i] = 1;
                paths[i] = sequence[i] + " ";
            }

            int maxLenght = 1;

            for (int i = 1; i < sequence.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sequence[i] > sequence[j] && sizes[i] < sizes[j] + 1)
                    {
                        sizes[i] = sizes[j] + 1;
                        paths[i] = paths[j] + sequence[i] + " ";
                        if (maxLenght < sizes[i])
                        {
                            maxLenght = sizes[i];
                        }
                    }
                }
            }

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sizes[i] == maxLenght)
                {
                    Console.WriteLine(paths[i]);
                    return;
                }
            }
        }
    }
}