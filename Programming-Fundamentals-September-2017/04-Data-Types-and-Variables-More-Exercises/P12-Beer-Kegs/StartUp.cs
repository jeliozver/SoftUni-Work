namespace P12_Beer_Kegs
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string biggestKeg = string.Empty;
            decimal currentBiggestKeg = decimal.MinValue;

            for (int i = 1; i <= n; i++)
            {
                string kegModel = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                long height = long.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * radius * radius * height;

                if (volume > currentBiggestKeg)
                {
                    currentBiggestKeg = volume;
                    biggestKeg = kegModel;            
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}