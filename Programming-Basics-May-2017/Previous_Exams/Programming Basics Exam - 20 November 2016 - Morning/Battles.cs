using System;

namespace PB_NovM_2016_6_Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int playerOnePokemons = int.Parse(Console.ReadLine());
            int playerTwoPokemons = int.Parse(Console.ReadLine());
            int battlesMax = int.Parse(Console.ReadLine());

            int battles = 0;

            for (int pokemonOne = 1; pokemonOne <= playerOnePokemons; pokemonOne++)
            {
                for (int pokemonTwo = 1; pokemonTwo <= playerTwoPokemons; pokemonTwo++)
                {
                    if (battles >= battlesMax)
                    {
                        return;
                    }

                    battles++;

                    Console.Write($"({pokemonOne} <-> {pokemonTwo}) ");
                }
            }
        }
    }
}