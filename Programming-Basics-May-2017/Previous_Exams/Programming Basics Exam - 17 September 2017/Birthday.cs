using System;

namespace PB_Sep_2_2017_1_Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int aquariumLenght = int.Parse(Console.ReadLine());
            int aquariumWidth = int.Parse(Console.ReadLine());
            int aquariumHeight = int.Parse(Console.ReadLine());
            double usedPercentage = double.Parse(Console.ReadLine());

            int aquariumVolume = aquariumLenght * aquariumWidth * aquariumHeight;
            double aquariumTotalLiters = aquariumVolume * 0.001;
            double percentage = usedPercentage * 0.01;
            double litersRequired = aquariumTotalLiters * (1 - percentage);

            Console.WriteLine($"{litersRequired:f3}");
        }
    }
}
