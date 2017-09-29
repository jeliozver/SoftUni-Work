using System;

namespace PB_August_2015_1_Daily_Calorie_Intake
{
    class DailyCalorieIntake
    {
        static void Main(string[] args)
        {
            int weightLbr = int.Parse(Console.ReadLine());
            int heightInch = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int workouts = int.Parse(Console.ReadLine());
            
            double weightKg = weightLbr / 2.2;
            double heightCm = heightInch * 2.54;
            double bmr = 0;
            double dci = 0;

            if (gender == 'm')
            {
                bmr = 66.5 + (13.75 * weightKg) + (5.003 * heightCm) - (6.755 * age);
            }
            else
            {
                bmr = 655 + (9.563 * weightKg) + (1.850 * heightCm) - (4.676 * age);
            }
            
            if (workouts >= 10)
            {
                dci = bmr * 1.9;
            }
            else if (workouts >= 7 && workouts <= 9)
            {
                dci = bmr * 1.725;
            }
            else if (workouts >= 4 && workouts <= 6)
            {
                dci = bmr * 1.55;
            }
            else if (workouts >= 1 && workouts <= 3)
            {
                dci = bmr * 1.375;
            }
            else
            {
                dci = bmr * 1.2;
            }

            Console.WriteLine("{0}", Math.Floor(dci));
        }
    }
}