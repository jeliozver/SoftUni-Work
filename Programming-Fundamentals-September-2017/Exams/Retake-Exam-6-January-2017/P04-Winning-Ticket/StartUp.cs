namespace P04_Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var nastyInputSplitter = new Regex(@"\s+,\s+|,\s+|\s+,|\t|\r|\n");
            string pattern = @"\${6,9}|\#{6,9}|\^{6,9}|\@{6,9}";
            var ticketsList = new List<string>();

            string tickets = Console.ReadLine();

            string[] ticketsSplit = nastyInputSplitter
                .Split(tickets)
                .Where(s => s != string.Empty)
                .ToArray();

            foreach (var ticket in ticketsSplit)
            {
                string result = string.Empty;

                if (ticket.Length == 20)
                {
                    bool numberSignJackpot = new string('#', 20) == ticket;
                    bool dollarSignJackpot = new string('$', 20) == ticket;
                    bool atSignJackpot = new string('@', 20) == ticket;
                    bool caretSignJackpot = new string('^', 20) == ticket;

                    bool isJackpot = numberSignJackpot || dollarSignJackpot ||
                        atSignJackpot || caretSignJackpot;

                    if (isJackpot)
                    {
                        result = $"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!";
                    }
                    else
                    {
                        var firstHalf = ticket.Substring(0, 10);
                        var secondHalf = ticket.Substring(10);

                        var firstHalfMatch = Regex.Match(firstHalf, pattern);
                        var secondHalfMatch = Regex.Match(secondHalf, pattern);
                        string matchStr = firstHalfMatch.ToString();

                        if (firstHalfMatch.Length == 0 || secondHalfMatch.Length == 0)
                        {
                            result = $"ticket \"{ticket}\" - no match";
                        }
                        else
                        {
                            if (firstHalfMatch.Length >= secondHalfMatch.Length)
                            {
                                matchStr = secondHalfMatch.ToString();
                            }

                            result = $"ticket \"{ticket}\" - {matchStr.Length}{matchStr[0]}";
                        }
                    }
                }
                else
                {
                    result = "invalid ticket";
                }

                ticketsList.Add(result);
            }

            foreach (var ticket in ticketsList)
            {
                Console.WriteLine(ticket);
            }
        }
    }
}
