namespace P05_Pizza_Ingredients
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] ingredients = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            long searchedLenght = long.Parse(Console.ReadLine());

            string[] ingredientsUsed = new string[101];
            int ingredientsAdded = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredientsAdded == 10)
                {
                    break;
                }
                if (ingredients[i].Length == searchedLenght)
                {
                    ingredientsUsed[i] = ingredients[i];
                    ingredientsAdded++;
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
            }

            ingredientsUsed = ingredientsUsed.Where(c => c != null).ToArray();
            string finalResult = string.Join(", ", ingredientsUsed);

            Console.WriteLine($"Made pizza with total of {ingredientsAdded} ingredients.");
            Console.WriteLine($"The ingredients are: {finalResult}.");
        }
    }
}