namespace P02_Max_Method
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(GetMax(numberOne, numberTwo), numberThree));
        }

        private static int GetMax(int a, int b)
        {
            int maxFromNumOneNumTwo = Math.Max(a, b);
            return maxFromNumOneNumTwo;
        }
    }
}   