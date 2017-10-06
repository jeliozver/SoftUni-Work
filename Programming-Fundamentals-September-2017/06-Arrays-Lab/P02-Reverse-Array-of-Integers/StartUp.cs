namespace P02_Reverse_Array_of_Integers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] arrayOfIntegers = new int[n];

            for (int i = arrayOfIntegers.Length; i > 0; i--)
            {
                int number = int.Parse(Console.ReadLine());

                arrayOfIntegers[i - 1] = number;
            }

            Console.WriteLine(string.Join(" ", arrayOfIntegers));
        }
    }
}