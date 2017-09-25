using System;

namespace Game_of_Numbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int lastComboFirstNum = 0;
            int lastComboSecondNum = 0;
            int combinations = 0;
            bool isMagicComboFound = false;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {
                        isMagicComboFound = true;
                        lastComboFirstNum = i;
                        lastComboSecondNum = j;
                    }
                }
            }

            if (isMagicComboFound)
            {
                Console.WriteLine($"Number found! {lastComboFirstNum} + {lastComboSecondNum} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}