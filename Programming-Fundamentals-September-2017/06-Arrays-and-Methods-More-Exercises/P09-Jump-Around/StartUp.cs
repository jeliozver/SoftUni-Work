namespace P09_Jump_Around
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

            int currentIndex = 0;
            int nextMove = numbers[currentIndex];
            int sum = 0;
            int previousIndex = 0;

            while (true)
            {
                try
                {
                    nextMove = numbers[currentIndex];
                }
                catch (Exception)
                {
                    nextMove = numbers[previousIndex - nextMove];
                }

                sum += nextMove;

                if (nextMove + currentIndex <= numbers.Length)
                {
                    currentIndex += nextMove;
                }
                else if (currentIndex - nextMove >= 0)
                {
                    currentIndex -= nextMove;
                }
                else
                {
                    break;
                }

                previousIndex = currentIndex;
            }

            Console.WriteLine(sum);
        }
    }
}