namespace P01_Sino_the_Walker
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var leaveTime = DateTime.ParseExact(
                Console.ReadLine(),
                "HH:mm:ss",
                CultureInfo.InvariantCulture);

            int stepsCount = int.Parse(Console.ReadLine());
            int timePerStepSeconds = int.Parse(Console.ReadLine());

            long leaveTimeSeconds = leaveTime.Hour * 3600
                                    + leaveTime.Minute * 60
                                    + leaveTime.Second;

            ulong walkTimeSeconds = (ulong)stepsCount * (ulong)timePerStepSeconds;
            ulong totalSeconds = (ulong)leaveTimeSeconds + walkTimeSeconds;

            ulong seconds = totalSeconds % 60;
            ulong totalMinutes = totalSeconds / 60;
            ulong minutes = totalMinutes % 60;
            ulong totalHours = totalMinutes / 60;
            ulong hours = totalHours % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}