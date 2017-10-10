namespace P02_Change_List
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

            string[] command = Console.ReadLine().Split(' ');

            string action = command[0];

            while (action != "Even" && action != "Odd")
            {
                int element = int.Parse(command[1]);

                if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
                else if (command[0] == "Delete")
                {
                    numbers.RemoveAll(item => item == element);
                }

                command = Console.ReadLine().Split(' ');
                action = command[0];
            }

            foreach (int index in numbers)
            {
                if (command[0] == "Even")
                {
                    if (index % 2 == 0)
                    {
                        Console.Write($"{index} ");
                    }
                }
                else
                {
                    if (index % 2 != 0)
                    {
                        Console.Write($"{index} ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}