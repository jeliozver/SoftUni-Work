namespace P04_Character_Multiplier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            string one = input[0];
            string two = input[1];

            Console.WriteLine(CharacterMultiplier(one, two));
        }

        public static int CharacterMultiplier(string one, string two)
        {
            string longerString = string.Empty;
            string shorterString = string.Empty;

            if (Math.Max(one.Length, two.Length) == one.Length)
            {
                longerString = one;
                shorterString = two;
            }
            else
            {
                longerString = two;
                shorterString = one;
            }

            int sum = 0;

            for (int i = 0; i < shorterString.Length; i++)
            {
                sum += shorterString[i] * longerString[i];
            }

            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }

            return sum;
        }
    }
}