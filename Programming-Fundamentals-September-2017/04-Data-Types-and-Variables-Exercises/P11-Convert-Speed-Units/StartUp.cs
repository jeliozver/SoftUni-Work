namespace P11_Convert_Speed_Units
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float mPerSecond = distance / (hours * 3600 + minutes * 60 + seconds);
            float kmPerHour = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            float mpPerHour = (distance / 1609) / (hours + minutes / 60 + seconds / 3600);

            Console.WriteLine(mPerSecond);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(mpPerHour);
        }
    }
}