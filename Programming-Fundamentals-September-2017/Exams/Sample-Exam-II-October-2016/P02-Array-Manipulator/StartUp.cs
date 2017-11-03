namespace P02_Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] args = command
                    .Split(' ')
                    .ToArray();

                string maincomm = args[0];

                if (maincomm == "exchange")
                {
                    int index = int.Parse(args[1]);

                    if (index < 0 || index > numbers.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        if (index != numbers.Length - 1)
                        {
                            int[] partOne = numbers.Skip(index + 1).ToArray();
                            int[] partTwo = numbers.Take(index + 1).ToArray();

                            numbers = partOne.Concat(partTwo).ToArray();
                        }
                    }
                }
                else if (maincomm == "max")
                {
                    string evenOrOdd = args[1];

                    if (evenOrOdd == "even")
                    {
                        int[] evens = numbers.Where(even => even % 2 == 0).ToArray();

                        if (evens.Length == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            int max = int.MinValue;
                            int index = 0;

                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 == 0)
                                {
                                    if (numbers[i] >= max)
                                    {
                                        max = numbers[i];
                                        index = i;
                                    }
                                }
                            }

                            Console.WriteLine(index);
                        }
                    }
                    else
                    {
                        int[] odds = numbers.Where(odd => odd % 2 != 0).ToArray();

                        if (odds.Length == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            int max = int.MinValue;
                            int index = 0;

                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    if (numbers[i] >= max)
                                    {
                                        max = numbers[i];
                                        index = i;
                                    }
                                }
                            }

                            Console.WriteLine(index);
                        }
                    }
                }
                else if (maincomm == "min")
                {
                    string evenOrOdd = args[1];

                    if (evenOrOdd == "even")
                    {
                        int[] evens = numbers.Where(even => even % 2 == 0).ToArray();

                        if (evens.Length == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            int min = int.MaxValue;
                            int index = 0;

                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 == 0)
                                {
                                    if (numbers[i] <= min)
                                    {
                                        min = numbers[i];
                                        index = i;
                                    }
                                }
                            }

                            Console.WriteLine(index);
                        }
                    }
                    else
                    {
                        int[] odds = numbers.Where(odd => odd % 2 != 0).ToArray();

                        if (odds.Length == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            int min = int.MaxValue;
                            int index = 0;

                            for (int i = 0; i < numbers.Length; i++)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    if (numbers[i] <= min)
                                    {
                                        min = numbers[i];
                                        index = i;
                                    }
                                }
                            }

                            Console.WriteLine(index);
                        }
                    }
                }
                else if (maincomm == "first")
                {
                    int count = int.Parse(args[1]);
                    string evenOrOdd = args[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (evenOrOdd == "even")
                        {
                            int[] evens = numbers.Where(even => even % 2 == 0).ToArray();
                            var evensToPrint = new List<int>();

                            for (int i = 0; i < evens.Length; i++)
                            {
                                if (evensToPrint.Count == count)
                                {
                                    break;
                                }

                                evensToPrint.Add(evens[i]);
                            }

                            Console.WriteLine($"[{string.Join(", ", evensToPrint)}]");
                        }
                        else
                        {
                            int[] odds = numbers.Where(odd => odd % 2 != 0).ToArray();
                            var oddsToPrint = new List<int>();

                            for (int i = 0; i < odds.Length; i++)
                            {
                                if (oddsToPrint.Count == count)
                                {
                                    break;
                                }

                                oddsToPrint.Add(odds[i]);
                            }

                            Console.WriteLine($"[{string.Join(", ", oddsToPrint)}]");
                        }
                    }
                }
                else if (maincomm == "last")
                {
                    int count = int.Parse(args[1]);
                    string evenOrOdd = args[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (evenOrOdd == "even")
                        {
                            int[] evens = numbers.Where(even => even % 2 == 0).ToArray();
                            var evensToPrint = new List<int>();

                            for (int i = evens.Length - 1; i >= 0; i--)
                            {
                                if (evensToPrint.Count == count)
                                {
                                    break;
                                }

                                evensToPrint.Add(evens[i]);
                            }

                            evensToPrint.Reverse();
                            Console.WriteLine($"[{string.Join(", ", evensToPrint)}]");
                        }
                        else
                        {
                            int[] odds = numbers.Where(odd => odd % 2 != 0).ToArray();
                            var oddsToPrint = new List<int>();

                            for (int i = odds.Length - 1; i >= 0; i--)
                            {
                                if (oddsToPrint.Count == count)
                                {
                                    break;
                                }

                                oddsToPrint.Add(odds[i]);
                            }

                            oddsToPrint.Reverse();
                            Console.WriteLine($"[{string.Join(", ", oddsToPrint)}]");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            string result = $"[{string.Join(", ", numbers)}]";
            Console.WriteLine(result);
        }
    }
}