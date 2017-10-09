namespace P02_Manipulate_Array
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

            int commandsToFollow = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsToFollow; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

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
                    int commandArgTwo = int.Parse(command[1]);
                    string commandArgThree = command[2];

                    inputArray[commandArgTwo] = commandArgThree;
                }
            }

            Console.WriteLine(string.Join(", ", inputArray));
        }
    }
}