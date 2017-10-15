namespace P03_Immune_System
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var virusesStats = new Dictionary<string, int>();

            long initialHealth = long.Parse(Console.ReadLine());
            string virus = Console.ReadLine();

            long remainingHealth = initialHealth;
            double nextHealth = initialHealth;

            while (virus != "end")
            {
                string virusName = virus;

                char[] virusStats = virus.ToCharArray();

                long virusStrenght = 0;

                foreach (var letter in virusStats)
                {
                    virusStrenght += letter;
                }

                virusStrenght /= 3;
                long timeToDefeat = virusStrenght * virusName.Length;

                if (!virusesStats.ContainsKey(virusName))
                {
                    virusesStats[virusName] = 0;
                }

                virusesStats[virusName]++;

                if (virusesStats[virusName] >= 2)
                {
                    timeToDefeat /= 3;
                }

                if (timeToDefeat >= remainingHealth)
                {
                    Console.WriteLine($"Virus {virusName}: " +
                                      $"{virusStrenght} => " +
                                      $"{timeToDefeat} seconds");

                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                remainingHealth -= timeToDefeat;
                long healthToPrint = remainingHealth;
                nextHealth = remainingHealth + remainingHealth * 0.20;

                if (nextHealth > initialHealth)
                {
                    nextHealth = initialHealth;
                }

                remainingHealth = (long)nextHealth;

                long minutes = 0;
                long seconds = timeToDefeat;

                while (seconds >= 60)
                {
                    minutes++;
                    seconds -= 60;
                }

                Console.WriteLine($"Virus {virusName}: " +
                                  $"{virusStrenght} => " +
                                  $"{timeToDefeat} seconds");

                Console.WriteLine($"{virusName} defeated in " +
                                  $"{minutes}m {seconds}s.");

                Console.WriteLine($"Remaining health: {healthToPrint}");

                virus = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {(int)nextHealth}");
        }
    }
}