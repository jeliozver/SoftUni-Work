namespace P07_Exchange_Variable_Values
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {numberOne}");
            Console.WriteLine($"b = {numberTwo}");

            int numberOneSave = numberOne;
            numberOne = numberTwo;
            numberTwo = numberOneSave;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {numberOne}");
            Console.WriteLine($"b = {numberTwo}");
        }
    }
}