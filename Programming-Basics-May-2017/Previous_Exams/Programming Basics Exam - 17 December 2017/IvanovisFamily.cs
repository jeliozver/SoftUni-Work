namespace PB_Dec_2_2017_1_Ivanovis_Family
{
    using System;

    public class IvanovisFamily
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal firstChildPresent = decimal.Parse(Console.ReadLine());
            decimal secondChildPresent = decimal.Parse(Console.ReadLine());
            decimal thirdChildPresent = decimal.Parse(Console.ReadLine());

            decimal budgetAfterPresents = budget - (firstChildPresent + secondChildPresent + thirdChildPresent);
            decimal budgetAfterTax = budgetAfterPresents - (budgetAfterPresents * 0.10m);

            Console.WriteLine($"{budgetAfterTax:f2}");
        }
    }
}