using System;

namespace Cake_Ingredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int ingredientsCount = 0;

            while (ingredient != "Bake!")
            {
                ingredientsCount++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
        }
    }
}