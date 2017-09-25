using System;
using System.Globalization;

namespace Date_After_5_Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            string month = Console.ReadLine();

            if (month == "1" || month == "2" || month == "3" || month == "4" || 
                month == "5" || month == "6" || month == "7" || month == "8" ||
                month == "9")
            {
                month = "0" + month;
            }

            string join = day + "." + month;

            string format = "d.MM";
            DateTime result = DateTime.ParseExact(join, format, CultureInfo.InvariantCulture);
            result = result.AddDays(5);

            Console.WriteLine(result.ToString(format));
        }
    }
}
