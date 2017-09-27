namespace P04_Beverage_Labels
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyContent = energy * ((double)volume / 100);
            double sugarContent = sugar * ((double)volume / 100);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
