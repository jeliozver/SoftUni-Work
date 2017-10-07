namespace P01_Largest_Common_End
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int matchesLeftCount = CountEqualSections(firstArray, secondArray);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int matchesRightCount = CountEqualSections(firstArray, secondArray);

            Console.WriteLine(Math.Max(matchesLeftCount, matchesRightCount));
        }

        private static int CountEqualSections(string[] firstArray, string[] secondArray)
        {
            int shorterArray = Math.Min(firstArray.Length, secondArray.Length);
            int matches = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    matches++;
                }
                else
                {
                    break;
                }
            }

            return matches;
        }
    }
}