namespace P17_Be_Positive
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            PrintOnlyPositiveNumbersInSequence(countSequences);
        }

        private static List<int> RemoveWhiteSpaces(string input)
        {
            input = Regex.Replace(input, " {2,}", " ").Trim();
            string[] parameters = input.Split(' ');

            var numbers = new List<int>();

            for (int j = 0; j < parameters.Length; j++)
            {
                int num = int.Parse(parameters[j]);
                numbers.Add(num);
            }

            return numbers;
        }

        private static void PrintOnlyPositiveNumbersInSequence(int countSequences)
        {
            for (int i = 0; i < countSequences; i++)
            {
                string input = Console.ReadLine();

                RemoveWhiteSpaces(input);
                var numbers = RemoveWhiteSpaces(input);

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        try
                        {
                            currentNum += numbers[j + 1];
                        }
                        catch (Exception)
                        {
                        }

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }

                        j++;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}