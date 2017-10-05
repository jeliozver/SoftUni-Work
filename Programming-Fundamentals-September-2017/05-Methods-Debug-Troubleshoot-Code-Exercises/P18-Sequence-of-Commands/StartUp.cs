namespace P18_Sequence_of_Commands
{
    using System;
    using System.Linq;
    public class StartUp
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] stringParams = command.Split(ArgumentsDelimiter);
                int[] args = new int[2];
                string action = stringParams[0];

                if (action.Equals("add") ||
                    action.Equals("subtract") ||
                    action.Equals("multiply"))
                {

                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, action, args);
                }
                else
                {
                    PerformAction(array, action, args);
                }

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }

            PrintArray(array);
        }

        private static void ArrayShiftRight(long[] array)
        {
            long oldArrayLastDigit = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = oldArrayLastDigit;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long oldArrayFirstDigit = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = oldArrayFirstDigit;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}