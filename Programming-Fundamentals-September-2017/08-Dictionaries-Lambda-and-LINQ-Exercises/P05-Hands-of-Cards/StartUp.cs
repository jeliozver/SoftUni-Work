namespace P05_Hands_of_Cards
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var cardsValues = new Dictionary<string, int>();
            {
                cardsValues["2"] = 2;
                cardsValues["3"] = 3;
                cardsValues["4"] = 4;
                cardsValues["5"] = 5;
                cardsValues["6"] = 6;
                cardsValues["7"] = 7;
                cardsValues["8"] = 8;
                cardsValues["9"] = 9;
                cardsValues["10"] = 10;
                cardsValues["J"] = 11;
                cardsValues["Q"] = 12;
                cardsValues["K"] = 13;
                cardsValues["A"] = 14;
            };

            var typeValues = new Dictionary<string, int>();
            {
                typeValues["S"] = 4;
                typeValues["H"] = 3;
                typeValues["D"] = 2;
                typeValues["C"] = 1;
            };

            var scoreSheet = new Dictionary<string, List<int>>();

            string hand = Console.ReadLine();

            while (hand != "JOKER")
            {
                string[] arguments = hand.Split(':');

                string name = arguments[0];
                string[] cards = arguments[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    string cardPower = card.Substring(0, card.Length - 1);
                    string cardType = card.Substring(card.Length - 1);

                    int sum = cardsValues[cardPower] * typeValues[cardType];

                    if (!scoreSheet.ContainsKey(name))
                    {
                        scoreSheet[name] = new List<int>();
                    }

                    if (!scoreSheet[name].Contains(sum))
                    {
                        scoreSheet[name].Add(sum);
                    }
                }

                hand = Console.ReadLine();
            }

            foreach (var name in scoreSheet)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Sum()}");
            }
        }
    }
}