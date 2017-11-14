namespace P01_SoftUni_Airline
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int flightsCount = int.Parse(Console.ReadLine());

            decimal overallProfit = 0m;

            for (int i = 0; i < flightsCount; i++)
            {
                int adultsCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthsCount = int.Parse(Console.ReadLine());
                decimal youthsTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultsCount * adultTicketPrice) + (youthsCount * youthsTicketPrice);
                decimal expences = flightDuration * fuelConsumption * fuelPrice;

                decimal profit = income - expences;
                overallProfit += profit;

                Console.WriteLine(income >= expences
                    ? $"You are ahead with {profit:f3}$."
                    : $"We've got to sell more tickets! We've lost {profit:f3}$.");
            }

            Console.WriteLine($"Overall profit -> {overallProfit:f3}$.");
            Console.WriteLine($"Average profit -> {overallProfit / flightsCount:f3}$.");
        }
    }
}