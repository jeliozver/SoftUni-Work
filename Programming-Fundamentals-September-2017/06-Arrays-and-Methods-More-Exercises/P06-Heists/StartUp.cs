namespace P06_Heists
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] prices = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string[] heistInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int jewelsPrice = prices[0];
            int goldPrice = prices[1];
            int jewelsCount = 0;
            int goldCount = 0;
            double totalEarnings = 0;
            double totalExpences = 0;

            while (heistInfo[0] != "Jail" && heistInfo[1] != "Time")
            {
                jewelsCount += heistInfo[0].Count(ch => ch == '%');
                goldCount += heistInfo[0].Count(ch => ch == '$');
                double heistExpenses = double.Parse(heistInfo[1]);
                totalExpences += heistExpenses;

                heistInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            totalEarnings = jewelsCount * jewelsPrice + goldCount * goldPrice - totalExpences;

            Console.WriteLine(totalEarnings >= 0
                ? $"Heists will continue. Total earnings: {totalEarnings}."
                : $"Have to find another job. Lost: {Math.Abs(totalEarnings)}.");
        }
    }
}