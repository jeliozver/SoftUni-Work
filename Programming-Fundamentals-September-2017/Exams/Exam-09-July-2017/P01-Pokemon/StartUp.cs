namespace P01_Pokemon
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            decimal pokePowerStartValue = pokePower;
            int pokesCount = 0;

            while (pokePower >= pokeDistance)
            {
                pokePower -= pokeDistance;
                pokesCount++;

                if (pokePower < pokeDistance)
                {
                    break;
                }

                decimal fiftyPercTest = 100.0m / (pokePowerStartValue / pokePower);
                bool isExactlyFiftyPerc = fiftyPercTest == 50.0m;

                if (!isExactlyFiftyPerc) continue;

                if (exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokesCount);
        }
    }
}