namespace P02_Email_Me
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] email = Console.ReadLine()
                .Split('@')
                .ToArray();

            string leftSide = email[0];
            string rightSide = email[1];

            long leftSideSum = 0;
            long rightSideSum = 0;

            foreach (char letter in leftSide)
            {
                leftSideSum += letter;
            }

            foreach (char letter in rightSide)
            {
                rightSideSum += letter;
            }

            long result = leftSideSum - rightSideSum;

            Console.WriteLine(result >= 0 
                ? "Call her!" 
                : "She is not the one.");
        }
    }
}