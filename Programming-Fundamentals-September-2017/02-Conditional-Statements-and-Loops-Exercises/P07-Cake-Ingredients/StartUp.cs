namespace P07_Cake_Ingredients
{
    using System;

    public class StartUp
    {
        public static void Main()
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
