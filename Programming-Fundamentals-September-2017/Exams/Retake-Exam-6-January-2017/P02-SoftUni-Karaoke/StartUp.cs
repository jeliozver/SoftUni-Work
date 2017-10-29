namespace P02_SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var nastyInputSplitter = new Regex(@",\s+|\t+|\r+|\n+");
            var awards = new SortedDictionary<string, SortedDictionary<string, int>>();

            string[] participants = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string songs = Console.ReadLine();

            string[] songsSplit = nastyInputSplitter
                .Split(songs)
                .Where(s => s != string.Empty)
                .ToArray();

            string currentPerformance = Console.ReadLine();

            while (currentPerformance != "dawn")
            {
                string[] arguments = nastyInputSplitter
                    .Split(currentPerformance)
                    .Where(s => s != string.Empty)
                    .ToArray();

                string currentParticipant = arguments[0];
                string currentSong = arguments[1];
                string currentAward = arguments[2];

                if (participants.Contains(currentParticipant) && songsSplit.Contains(currentSong))
                {
                    if (!awards.ContainsKey(currentParticipant))
                    {
                        awards[currentParticipant] = new SortedDictionary<string, int>();
                    }

                    if (!awards[currentParticipant].ContainsKey(currentAward))
                    {
                        awards[currentParticipant][currentAward] = 0;
                    }

                    awards[currentParticipant][currentAward]++;
                }

                currentPerformance = Console.ReadLine();
            }

            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            var awardsSorted = awards.OrderByDescending(x => x.Value.Count);

            foreach (var participant in awardsSorted)
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                foreach (var award in participant.Value)
                {
                    Console.WriteLine($"--{award.Key}");
                }
            }
        }
    }
}