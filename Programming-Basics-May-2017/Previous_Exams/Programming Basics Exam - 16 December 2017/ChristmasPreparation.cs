namespace PB_Dec_2017_1_Christmas_Preparation
{
    using System;

    public class ChristmasPreparation
    {
        public static void Main()
        {
            byte paperRollsCount = byte.Parse(Console.ReadLine());
            byte fabricRollsCount = byte.Parse(Console.ReadLine());
            float glueLitters = float.Parse(Console.ReadLine());
            byte discountPercent = byte.Parse(Console.ReadLine());

            decimal paperRollsPrice = (decimal)(paperRollsCount * 5.80);
            decimal fabricRollsPrice = (decimal)(fabricRollsCount * 7.20);
            decimal gluePrice = (decimal)(glueLitters * 1.20);

            decimal materialsTotalPrice = paperRollsPrice + fabricRollsPrice + gluePrice;

            decimal discountPrice = materialsTotalPrice - (materialsTotalPrice * discountPercent / 100);

            Console.WriteLine($"{discountPrice:f3}");
        }
    }
}