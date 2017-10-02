namespace P05_Weather_Forecast
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            try
            {
                long test = long.Parse(number);
                if (test >= sbyte.MinValue && test <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (test >= int.MinValue && test <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (test >= long.MinValue && test <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}