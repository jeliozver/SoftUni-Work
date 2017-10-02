namespace P01_Practice_Integers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            sbyte numberOne = sbyte.Parse(Console.ReadLine());
            byte numberTwo = byte.Parse(Console.ReadLine());
            short numberThree = short.Parse(Console.ReadLine());
            ushort numberFour = ushort.Parse(Console.ReadLine());
            uint numberFive = uint.Parse(Console.ReadLine());
            int numberSix = int.Parse(Console.ReadLine());
            long numberSeven = long.Parse(Console.ReadLine());

            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);
            Console.WriteLine(numberFour);
            Console.WriteLine(numberFive);
            Console.WriteLine(numberSix);
            Console.WriteLine(numberSeven);
        }
    }
}
