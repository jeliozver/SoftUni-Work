namespace PB_Dec_2_2017_4_Workout
{
    using System;

    public class Workout
    {
        public static void Main()
        {
            int trainingDays = int.Parse(Console.ReadLine());
            double kilometersRun = double.Parse(Console.ReadLine());

            double totalKilometers = kilometersRun;

            for (int i = 0; i < trainingDays; i++)
            {
                int percentIncrease = int.Parse(Console.ReadLine());

                double curentIncrease = kilometersRun * (percentIncrease / 100.00);
                kilometersRun += curentIncrease;
                totalKilometers += kilometersRun;
            }
        
            Console.WriteLine(totalKilometers >= 1000
                ? $"You've done a great job running {Math.Ceiling(totalKilometers - 1000)} more kilometers!"
                : $"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKilometers)} more kilometers");
        }
    }
}