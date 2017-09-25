using System;

namespace Character_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthRemaining = new string('|', currentHealth);
            string healthTaken = new string('.', maxHealth - currentHealth);

            string energyRemaining = new string('|', currentEnergy);
            string energyTaken = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthRemaining}{healthTaken}|");
            Console.WriteLine($"Energy: |{energyRemaining}{energyTaken}|");
        }
    }
}