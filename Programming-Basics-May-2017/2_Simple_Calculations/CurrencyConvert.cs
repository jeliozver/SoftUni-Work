using System;

namespace Currency_Converter
{
    class CurrencyConvert
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string currencyInput = (Console.ReadLine()).ToUpper();
            string currencyOutput = (Console.ReadLine()).ToUpper();

            if (currencyInput == "USD")
            {
                amount = amount * 1.79549m;
            }
            else if (currencyInput == "EUR")
            {
                amount = amount * 1.95583m;
            }
            else if (currencyInput == "GBP")
            {
                amount = amount * 2.53405m;
            }

            if (currencyOutput == "USD")
            {
                amount = amount / 1.79549m;
            }
            else if (currencyOutput == "EUR")
            {
                amount = amount / 1.95583m;
            }
            else if (currencyOutput == "GBP")
            {
                amount = amount / 2.53405m;
            }

            Console.WriteLine(Math.Round(amount, 2) + " " + currencyOutput);
        }
    }
}
