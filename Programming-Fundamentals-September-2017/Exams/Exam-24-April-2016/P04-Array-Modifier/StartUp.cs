namespace P04_Array_Modifier
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] args = command
                    .Split(' ')
                    .ToArray();

                string action = args[0];

                if (action == "swap")
                {
                    int indexOne = int.Parse(args[1]);
                    int indexTwo = int.Parse(args[2]);

                    long firstNumber = numbers[indexOne];
                    long secondNumber = numbers[indexTwo];

                    numbers[indexTwo] = firstNumber;
                    numbers[indexOne] = secondNumber;
                }
                else if (action == "multiply")
                {
                    int indexOne = int.Parse(args[1]);
                    int indexTwo = int.Parse(args[2]);

                    numbers[indexOne] *= numbers[indexTwo];

                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}