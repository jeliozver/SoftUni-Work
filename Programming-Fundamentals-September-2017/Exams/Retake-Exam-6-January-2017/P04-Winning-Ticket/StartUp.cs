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

                    var numberSignMatches = Regex.Matches(ticket, @"\#{6,9}");
                    var dollarSignMatches = Regex.Matches(ticket, @"\${6,9}");
                    var atSignMatches = Regex.Matches(ticket, @"\@{6,9}");
                    var caretSignMatches = Regex.Matches(ticket, @"\^{6,9}");

                    bool isTicketWinning = numberSignMatches.Count == 2 || dollarSignMatches.Count == 2 ||
                                           atSignMatches.Count == 2 || caretSignMatches.Count == 2;

                    bool isJackpot = numberSignJackpot || dollarSignJackpot ||
                        atSignJackpot || caretSignJackpot;

                    if (isJackpot)
                    {
                        result = $"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!";
                    }
                    else if (!isTicketWinning)
                    {
                        result = $"ticket \"{ticket}\" - no match";
                    }
                    else
                    {
                        var firstHalf = ticket.Substring(0, 10);
                        var secondHalf = ticket.Substring(10);

                        string pattern = @"\${6,9}|\#{6,9}|\^{6,9}|\@{6,9}";

                        var firstHalfMatch = Regex.Match(firstHalf, pattern);
                        var secondHalfMatch = Regex.Match(secondHalf, pattern);

                        var match = Regex.Match(secondHalf, @"\${6,9}|\#{6,9}|\^{6,9}|\@{6,9}");

                        if (firstHalfMatch.Length <= secondHalfMatch.Length)
                        {
                            match = Regex.Match(firstHalf, @"\${6,9}|\#{6,9}|\^{6,9}|\@{6,9}");
                        }

                        string matchStr = match.ToString();

                        result = $"ticket \"{ticket}\" - {matchStr.Length}{matchStr[0]}";
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