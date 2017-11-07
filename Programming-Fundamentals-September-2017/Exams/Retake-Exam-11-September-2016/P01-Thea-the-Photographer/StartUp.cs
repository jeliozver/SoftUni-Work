namespace P01_Thea_the_Photographer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine());
            int filterFactorPercent = int.Parse(Console.ReadLine());
            int uploadTimePerGoodPicture = int.Parse(Console.ReadLine());

            double totalFilterTime = (long)totalPictures * filterTimePerPicture;
            double totalGoodPictures = (long)Math.Ceiling(totalPictures * (filterFactorPercent / 100.0));
            double totalUploadTime = uploadTimePerGoodPicture * totalGoodPictures;
            double totalTimeInSeconds = totalFilterTime + totalUploadTime;

            TimeSpan convertTime = TimeSpan.FromSeconds(totalTimeInSeconds);
            string convertTimeOutput = convertTime.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(convertTimeOutput);
        }
    }
}