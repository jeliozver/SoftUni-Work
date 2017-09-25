using System;

namespace Fruit_or_Vegetable
{
    class fruitOrVegetable
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isFruit = input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" ||
                           input == "lemon" || input == "grapes";
            bool isVegetable = input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot";

            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
