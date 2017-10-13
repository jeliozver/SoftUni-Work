namespace P11_Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, double[]>>();

            int dragonsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragonsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split(' ');

                string dragonType = arguments[0];
                string dragonName = arguments[1];
                double dragonDamage = 0;
                double dragonHealth = 0;
                double dragonArmor = 0;

                dragonDamage = arguments[2] != "null" ? double.Parse(arguments[2]) : 45;
                dragonHealth = arguments[3] != "null" ? double.Parse(arguments[3]) : 250;
                dragonArmor = arguments[4] != "null" ? double.Parse(arguments[4]) : 10;

                if (!dragons.ContainsKey(dragonType))
                {
                    dragons[dragonType] = new SortedDictionary<string, double[]>();
                }

                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType][dragonName] = new[] { 0d, 0d, 0d };
                }

                dragons[dragonType][dragonName] = new[] { dragonDamage, dragonHealth, dragonArmor };
            }

            foreach (var type in dragons)
            {
                double averageDamage = type.Value.Values.Average(avg => avg[0]);
                double averageHealth = type.Value.Values.Average(avg => avg[1]);
                double averageArmor = type.Value.Values.Average(avg => avg[2]);

                Console.WriteLine($"{type.Key}::" +
                                  $"({averageDamage:f2}" +
                                  $"/{averageHealth:f2}/" +
                                  $"{averageArmor:f2})");

                foreach (var dragon in dragons[type.Key])
                {
                    Console.WriteLine($"-{dragon.Key} -> " +
                                      $"damage: {dragon.Value[0]:f0}, " +
                                      $"health: {dragon.Value[1]:f0}, " +
                                      $"armor: {dragon.Value[2]:f0}");
                }
            }
        }
    }
}