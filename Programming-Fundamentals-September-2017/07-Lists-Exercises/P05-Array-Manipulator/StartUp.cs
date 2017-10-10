namespace P05_Array_Manipulator
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

            string[] arguments = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (arguments[0] != "print")
            {
                if (arguments[0] == "add")
                {
                    int index = int.Parse(arguments[1]);
                    int element = int.Parse(arguments[2]);

                    numbers.Insert(index, element);
                }
                else if (arguments[0] == "addMany")
                {
                    int index = int.Parse(arguments[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < arguments.Length; i++)
                    {
                        elements.Add(int.Parse(arguments[i]));
                    }

                    numbers.InsertRange(index, elements);
                }
                else if (arguments[0] == "contains")
                {
                    int element = int.Parse(arguments[1]);
                    IsContainsElementAtIndex(numbers, element);
                }
                else if (arguments[0] == "remove")
                {
                    int index = int.Parse(arguments[1]);
                    numbers.RemoveAt(index);
                }
                else if (arguments[0] == "shift")
                {
                    int positions = int.Parse(arguments[1]);

                    numbers = ShiftElements(numbers, positions);
                }
                else if (arguments[0] == "sumPairs")
                {
                    numbers = SumPairs(numbers);
                }

                arguments = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static List<int> ShiftElements(List<int> array, int pos)
        {
            int positions = pos;

            for (int i = 0; i < positions; i++)
            {
                int lastElement = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Count - 1] = lastElement;
            }

            return array;
        }

        private static void IsContainsElementAtIndex(List<int> array, int element)
        {
            bool isIndexFound = false;

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == element)
                {
                    isIndexFound = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!isIndexFound)
            {
                Console.WriteLine("-1");
            }
        }

        private static List<int> SumPairs(List<int> array)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Count; i += 2)
            {
                int currentSum = 0;

                if (i + 2 > array.Count)
                {
                    currentSum = array[array.Count - 1];
                }
                else
                {
                    currentSum = array[i] + array[i + 1];
                }

                result.Add(currentSum);
            }

            return result;
        }
    }
}