namespace P01_Most_Frequent_Number
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string text = "Input.txt";
            string input = File.ReadAllText(text);

            int[] numbers = input
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int longestStreak = 0;
            int mostFrequentNumber = 0;

            foreach (int num in numbers)
            {
                int counter = 0;

                foreach (int number in numbers)
                {
                    if (number == num)
                    {
                        counter++;
                    }
                }

                if (counter <= longestStreak) continue;
                longestStreak = counter;
                mostFrequentNumber = num;
            }

            string result = mostFrequentNumber.ToString();

            File.WriteAllText("Output.txt", result);
        }
    }
}