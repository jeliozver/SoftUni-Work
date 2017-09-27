namespace P02_Add_Two_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }
    }
}
