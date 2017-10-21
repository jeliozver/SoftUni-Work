namespace P07_Play_Catch
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int exceptionsCount = 0;

            while (exceptionsCount < 3)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] arguments = input
                        .Split(' ')
                        .ToArray();

                    string command = arguments[0];

                    if (command.Equals("Replace"))
                    {
                        int index = int.Parse(arguments[1]);
                        int number = int.Parse(arguments[2]);

                        numbers[index] = number;
                    }
                    else if (command.Equals("Print"))
                    {
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);

                        var result = new List<int>();

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            result.Add(numbers[i]);
                        }

                        Console.WriteLine(string.Join(", ", result));
                    }
                    else if (command.Equals("Show"))
                    {
                        int index = int.Parse(arguments[1]);

                        Console.WriteLine($"{numbers[index]}");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionsCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCount++;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}