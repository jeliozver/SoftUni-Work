namespace P02_Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            string currentCommand = Console.ReadLine();

            while (currentCommand != "end")
            {
                string[] arguments = currentCommand
                    .Split(' ')
                    .ToArray();

                string command = arguments[0];

                if (command == "reverse")
                {
                    int start = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);

                    input = ReverseOrSort(input, command, start, count);
                }
                else if (command == "sort")
                {
                    int start = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);

                    input = ReverseOrSort(input, command, start, count);
                }
                else if (command == "rollLeft")
                {
                    int count = int.Parse(arguments[1]);

                    input = RollLeftOrRight(input, count, command);
                }
                else if (command == "rollRight")
                {
                    int count = int.Parse(arguments[1]);

                    input = RollLeftOrRight(input, count, command);
                }

                currentCommand = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static List<string> ReverseOrSort(List<string> input, string command, int start, int count)
        {
            if (start < 0 || start > input.Count - 1 || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else if (start + count - 1 > input.Count - 1)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                var leftPart = new List<string>();
                var midPart = new List<string>();
                var rightPart = new List<string>();

                for (int i = 0; i < start; i++)
                {
                    leftPart.Add(input[i]);
                }

                for (int i = start; i < start + count; i++)
                {
                    midPart.Add(input[i]);
                }

                if (command == "reverse")
                {
                    midPart.Reverse();
                }
                else
                {
                    midPart.Sort();
                }

                for (int i = start + count; i < input.Count; i++)
                {
                    rightPart.Add(input[i]);
                }

                input = leftPart.Concat(midPart).ToList();
                input = input.Concat(rightPart).ToList();
            }

            return input;
        }

        public static List<string> RollLeftOrRight(List<string> input, int count, string command)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return input;
            }

            if (count == input.Count)
            {
                return input;
            }

            int end = count;

            if (count > input.Count)
            {
                end = count % input.Count;
            }

            if (command == "rollLeft")
            {
                for (int i = 0; i < end; i++)
                {
                    var takeFirst = input.Take(1).ToArray();
                    input.RemoveAt(0);
                    input.AddRange(takeFirst);
                }
            }
            else
            {
                for (int i = 0; i < end; i++)
                {
                    var takeLast = input.Skip(input.Count - 1).ToArray();
                    input.RemoveAt(input.Count - 1);
                    input.InsertRange(0, takeLast);
                }
            }

            return input;
        }
    }
}