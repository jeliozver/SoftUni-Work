using System;

namespace PB_March_1_2017_2__Work_Hours
{
    class workHours
    {
        static void Main(string[] args)
        {
            int hoursAvb = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int daysWorking = int.Parse(Console.ReadLine());

            int hoursWorking = workers * (daysWorking * 8);

            if (hoursWorking >= hoursAvb)
            {
                Console.WriteLine("{0} hours left", hoursWorking - hoursAvb);
            }
            else
            {
                Console.WriteLine("{0} overtime", hoursAvb - hoursWorking);
                Console.WriteLine("Penalties: {0}", (hoursAvb - hoursWorking) * daysWorking);
            }
        }
    }
}
