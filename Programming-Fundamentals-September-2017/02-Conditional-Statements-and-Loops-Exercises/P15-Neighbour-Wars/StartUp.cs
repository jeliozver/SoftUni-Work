namespace P15_Neighbour_Wars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int turn = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                turn++;
                if (turn % 2 != 0)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                }

                if (turn % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
