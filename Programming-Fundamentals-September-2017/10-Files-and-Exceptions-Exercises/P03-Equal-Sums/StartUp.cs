namespace P03_Equal_Sums
{
    using System;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = "Input.txt";

            int[] numbers = File.ReadAllText(input)
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isEqualSumsFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("Output.txt", i.ToString());
                    isEqualSumsFound = true;
                    break;
                }
            }

            if (!isEqualSumsFound)
            {
                File.WriteAllText("Output.txt", "no");
            }
        }
    }
}