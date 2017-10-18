namespace P03_Safe_Manipulation
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "END")
            {
                string commandArgOne = command[0];

                if (commandArgOne == "Distinct")
                {
                    inputArray = inputArray.Distinct().ToArray();
                }
                else if (commandArgOne == "Reverse")
                {
                    Array.Reverse(inputArray);
                }
                else if (commandArgOne == "Replace")
                {
                    try
                    {
                        int commandArgTwo = int.Parse(command[1]);
                        string commandArgThree = command[2];

                        inputArray[commandArgTwo] = commandArgThree;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine(string.Join(", ", inputArray));
        }
    }
}