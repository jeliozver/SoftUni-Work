namespace P02_Pokemon_Don_t_Go
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            long[] pokemons = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long sumRemoved = 0;
            long indexToRemove = long.Parse(Console.ReadLine());

            while (pokemons.Length > 0)
            {
                long removedItemValue = 0;

                if (indexToRemove < 0)
                {
                    removedItemValue = pokemons[0];
                    sumRemoved += removedItemValue;

                    pokemons[0] = pokemons[pokemons.Length - 1];

                    pokemons = ChangeElements(pokemons, removedItemValue);
                }
                else if (indexToRemove >= pokemons.Length)
                {
                    removedItemValue = pokemons[pokemons.Length - 1];
                    sumRemoved += removedItemValue;

                    pokemons[pokemons.Length - 1] = pokemons[0];

                    pokemons = ChangeElements(pokemons, removedItemValue);
                }
                else
                {
                    removedItemValue = pokemons[indexToRemove];
                    sumRemoved += removedItemValue;

                    pokemons = pokemons
                        .Where((source, index) => index != indexToRemove)
                        .ToArray();

                    pokemons = ChangeElements(pokemons, removedItemValue);
                }

                if (pokemons.Length == 0)
                {
                    break;
                }

                indexToRemove = long.Parse(Console.ReadLine());
            }

            Console.WriteLine(sumRemoved);
        }

        public static long[] ChangeElements(long[] pokemons, long removedItemValue)
        {
            for (int i = 0; i < pokemons.Length; i++)
            {
                if (pokemons[i] <= removedItemValue)
                {
                    pokemons[i] += removedItemValue;
                }
                else
                {
                    pokemons[i] -= removedItemValue;
                }
            }

            return pokemons;
        }
    }
}