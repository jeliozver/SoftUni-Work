using System;

namespace Add_Two_Numbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int sum = firstNum + secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }
    }
}