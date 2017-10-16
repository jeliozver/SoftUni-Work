namespace P01_Day_of_Week
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            string date = Console.ReadLine();

            DateTime result = DateTime.ParseExact(
                date,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(result.DayOfWeek);
        }
    }
}