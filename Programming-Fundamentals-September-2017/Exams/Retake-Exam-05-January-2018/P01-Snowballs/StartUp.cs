namespace P01_Snowballs
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int snowballsCount = int.Parse(Console.ReadLine());

            BigInteger snowballValueMax = ulong.MinValue;
            int snowballSnowMax = 0;
            int snowballTimeMax = 0;
            int snowballQualityMax = 0;

            for (int i = 0; i < snowballsCount; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                var snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue < snowballValueMax) continue;
                snowballValueMax = snowballValue;
                snowballSnowMax = snowballSnow;
                snowballTimeMax = snowballTime;
                snowballQualityMax = snowballQuality;
            }

            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}