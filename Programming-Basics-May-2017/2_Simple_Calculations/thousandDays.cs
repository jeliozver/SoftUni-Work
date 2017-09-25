using System;
using System.Globalization;

namespace Thousand_Days
{
    class thousandDays
    {
        static void Main(string[] args)
        {
            string birth = Console.ReadLine();

            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(birth, format, CultureInfo.InvariantCulture);
            result = result.AddDays(999);

            Console.WriteLine(result.ToString(format));
        }
    }
}