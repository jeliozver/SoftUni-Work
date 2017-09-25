using System;

namespace PB_Aug_2016_2_Firm
{
    class firm
    {
        static void Main(string[] args)
        {
            int hoursRq = int.Parse(Console.ReadLine());
            int daysAvb = int.Parse(Console.ReadLine());
            int workersBonus = int.Parse(Console.ReadLine());

            double normalWork = (daysAvb - (daysAvb * 0.10)) * 8;
            double bonusWork = workersBonus * (2 * daysAvb);
            double hoursWork = Math.Floor(normalWork) + Math.Floor(bonusWork);

            if (hoursWork >= hoursRq)
            {
                double hoursLeft = hoursWork - hoursRq;
                Console.WriteLine("Yes!{0} hours left.", hoursLeft);
            }
            else
            {
                double hoursNeed = hoursRq - hoursWork;
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeed);
            }
        }
    }
}
