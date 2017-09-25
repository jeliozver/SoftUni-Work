using System;

namespace PB_Aug_2016_4_Hospital
{
    class hospital
    {
        static void Main(string[] args)
        {
            int timeSpan = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatiens = 0;
            int doctors = 7;

            for (int i = 1; i <= timeSpan; i++)
            {
                int dailyPatients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (treatedPatients < untreatedPatiens)
                    {
                        doctors++;
                    }
                    if (doctors >= dailyPatients)
                    {
                        treatedPatients += dailyPatients;
                    }
                    else
                    {
                        untreatedPatiens += dailyPatients - doctors;
                        treatedPatients += doctors;
                    }
                }
                else
                {
                    if (doctors >= dailyPatients)
                    {
                        treatedPatients += dailyPatients;
                    }
                    else
                    {
                        untreatedPatiens += dailyPatients - doctors;
                        treatedPatients += doctors;
                    }
                }
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatiens);
        }
    }
}