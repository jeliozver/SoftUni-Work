namespace P07_Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] arguments = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int specialNumber = arguments[0];
            int bombPower = arguments[1];

            bool hasDetonationsStopped = true;

            while (hasDetonationsStopped)
            {
                hasDetonationsStopped = false;

                int startIndex = 0;
                int detonated = 0;

                List<int> remainingsLeft = new List<int>();
                List<int> remainingsRight = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == specialNumber)
                    {
                        startIndex = i - bombPower;

                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }

                        detonated = i + bombPower + 1;

                        if (detonated > numbers.Count)
                        {
                            detonated = numbers.Count;
                        }

                        hasDetonationsStopped = true;
                        break;
                    }
                }

                if (hasDetonationsStopped)
                {
                    remainingsLeft = numbers.Take(startIndex).ToList();
                    remainingsRight = numbers.Skip(detonated).ToList();

                    numbers = remainingsLeft;
                    numbers.AddRange(remainingsRight);
                }
            }

            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}