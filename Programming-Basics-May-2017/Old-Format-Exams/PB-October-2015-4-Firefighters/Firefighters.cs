using System;

namespace PB_October_2015_4_Firefighters
{
    class Firefighters
    {
        static void Main(string[] args)
        {
            int firefightersCount = int.Parse(Console.ReadLine());
            string currentAlert = Console.ReadLine();

            int kidsSaved = 0;
            int adultsSaved = 0;
            int seniorsSaved = 0;

            while (currentAlert != "rain")
            {
                string savingOrder = string.Empty;
                int kidsToBeSaved = 0;
                int adultsToBeSaved = 0;
                int seniorsToBeSaved = 0;

                for (int i = 0; i < currentAlert.Length; i++)
                {
                    if (kidsToBeSaved >= firefightersCount)
                    {
                        break;
                    }

                    if (currentAlert[i] == 'K')
                    {
                        kidsToBeSaved++;
                    }
                    else if (currentAlert[i] == 'A')
                    {
                        adultsToBeSaved++;
                    }
                    else if (currentAlert[i] == 'S')
                    {
                        seniorsToBeSaved++;
                    }
                }

                string kids = new string('K', kidsToBeSaved);
                string adults = new string('A', adultsToBeSaved);
                string seniors = new string('S', seniorsToBeSaved);
                savingOrder = kids + adults + seniors;
                savingOrder = TruncateString(savingOrder, firefightersCount);

                for (int i = 0; i < savingOrder.Length; i++)
                {
                    if (savingOrder[i] == 'K')
                    {
                        kidsSaved++;
                    }
                    else if (savingOrder[i] == 'A')
                    {
                        adultsSaved++;
                    }
                    else if (savingOrder[i] == 'S')
                    {
                        seniorsSaved++;
                    }
                }

                currentAlert = Console.ReadLine();
            }

            Console.WriteLine($"Kids: {kidsSaved}");
            Console.WriteLine($"Adults: {adultsSaved}");
            Console.WriteLine($"Seniors: {seniorsSaved}");
        }

        public static string TruncateString(string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }
            return source;
        }
    }
}