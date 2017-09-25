using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nightsCount = decimal.Parse(Console.ReadLine());

            decimal studioPrice = 0.00m;
            decimal doublePrice = 0.00m;
            decimal suitePrice = 0.00m;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nightsCount;
                doublePrice = 65 * nightsCount;
                suitePrice = 75 * nightsCount;

                if (nightsCount > 7)
                {
                    studioPrice = (50 * 0.95m) * nightsCount;
                }
                if (nightsCount > 7 && month == "October")
                {
                    studioPrice -= 50 * 0.95m;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nightsCount;
                doublePrice = 72 * nightsCount;
                suitePrice = 82 * nightsCount;

                if (nightsCount > 14)
                {
                    doublePrice = (72 * 0.90m) * nightsCount;
                }
                if (month == "September" && nightsCount > 7)
                {
                    studioPrice -= 60;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightsCount;
                doublePrice = 77 * nightsCount;
                suitePrice = 89 * nightsCount;

                if (nightsCount > 14)
                {
                    suitePrice = (89 * 0.85m) * nightsCount;
                }
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}