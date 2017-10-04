namespace P11_Price_Change_Alert
{
    using System;

    public class StartUp
    {
        private static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 1; i < numberOfPrices; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double priceDifference = GetPriceDifference(lastPrice, currentPrice);
                bool isSignificantDifference = CheckForSignificantDifference(priceDifference, threshold);

                string message = GetPriceChangeAlert(currentPrice, lastPrice, priceDifference, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetPriceChangeAlert(double currentPrice, double lastPrice, double priceDifference, bool isSignificantDifference)
        {
            string message = string.Empty;

            if (priceDifference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:f2}%)", lastPrice, currentPrice, priceDifference *= 100);
            }
            else if (priceDifference > 0)
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:f2}%)", lastPrice, currentPrice, priceDifference *= 100);
            }
            else if (priceDifference < 0)
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:f2}%)", lastPrice, currentPrice, priceDifference *= 100);
            }

            return message;
        }

        private static bool CheckForSignificantDifference(double priceDifference, double threshold)
        {
            if (Math.Abs(priceDifference) >= threshold)
            {
                return true;
            }

            return false;
        }

        private static double GetPriceDifference(double lastPrice, double currentPrice)
        {
            double priceDifference = (currentPrice - lastPrice) / lastPrice;
            return priceDifference;
        }
    }
}