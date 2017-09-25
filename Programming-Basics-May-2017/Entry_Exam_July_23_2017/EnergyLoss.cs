using System;

namespace _04_Energy_Loss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            double trainingDays = double.Parse(Console.ReadLine());
            double dancersCount = double.Parse(Console.ReadLine());

            double evenDayEvenHours = 68;
            double oddDayEvenHours = 49;
            double evenDayOddHours = 65;
            double oddDayOddHours = 30;
            double energy = 0;

            for (int day = 1; day <= trainingDays; day++)
            {
                double hoursTraining = double.Parse(Console.ReadLine());

                if (day % 2 == 0)
                {
                    if (hoursTraining % 2 == 0)
                    {
                        energy += dancersCount * evenDayEvenHours;
                    }
                    else
                    {
                        energy += dancersCount * evenDayOddHours;
                    }
                }
                else
                {
                    if (hoursTraining % 2 == 0)
                    {
                        energy += dancersCount * oddDayEvenHours;
                    }
                    else
                    {
                        energy += dancersCount * oddDayOddHours;
                    }
                }
            }

            double fullEnergy = (100 * dancersCount) * trainingDays;
            double unusedEnergy = fullEnergy - energy;
            double usedEnergy = fullEnergy - unusedEnergy;
            double unusedEnergyPerDancer = (unusedEnergy / dancersCount) / trainingDays;

            if (usedEnergy <= unusedEnergy)
            {
                Console.WriteLine($"They feel good! Energy left: {unusedEnergyPerDancer:f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {unusedEnergyPerDancer:f2}");
            }
        }
    }
}