namespace P02_Count_Substring_Occurrences
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine()
                .ToLower();
            string pattern = Console.ReadLine()
                .ToLower();

            int index = 0;
            int occurancesCount = 0;

            while (true)
            {
                int found = text
                    .IndexOf(pattern, index);

                if (found >= 0)
                {
                    occurancesCount++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(occurancesCount);
        }
    }
}