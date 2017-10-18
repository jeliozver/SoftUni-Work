namespace P01_Count_Working_Days
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string format = "dd-MM-yyyy";

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                format, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                format, CultureInfo.InvariantCulture);

            int workingDays = 0;

            for (DateTime currentDate = startDate; 
                currentDate <= endDate; 
                currentDate = currentDate.AddDays(1))
            {
                if (currentDate.DayOfWeek != DayOfWeek.Saturday
                    && currentDate.DayOfWeek != DayOfWeek.Sunday &&
                    !IsHolidayInBulgaria(currentDate))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }

        private static bool IsHolidayInBulgaria(DateTime date)
        {
            string dateAsString = $"{date.Day}-{date.Month}";

            string[] holidaysInBulgaria = { "1-1", "3-3", "1-5",
                "6-5", "24-5", "6-9", "22-9",
                "1-11", "24-12", "25-12", "26-12" };

            return holidaysInBulgaria.Contains(dateAsString);
        }
    }
}