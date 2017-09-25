using System;

namespace Enter_Even_Num
{
    class enterEvenNum
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine($"Even number entered: {num}");
        }
    }
}