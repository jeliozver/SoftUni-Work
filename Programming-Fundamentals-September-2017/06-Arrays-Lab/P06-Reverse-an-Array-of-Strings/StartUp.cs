namespace P06_Reverse_an_Array_of_Strings
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string[] items = input.Split(' ');
            var reversed = items.Reverse();

            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}