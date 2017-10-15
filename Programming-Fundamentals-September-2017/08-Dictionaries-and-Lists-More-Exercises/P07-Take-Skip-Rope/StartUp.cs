namespace P07_Take_Skip_Rope
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string encryptedMessage = Console.ReadLine();

            List<char> numbersList = new List<char>();
            List<string> textList = new List<string>();

            foreach (char letter in encryptedMessage)
            {
                if (letter >= 48 && letter <= 57)
                {
                    numbersList.Add(letter);
                }
                else
                {
                    textList.Add(letter.ToString());
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(int.Parse(Convert.ToString(numbersList[i])));
                }
                else
                {
                    skipList.Add(int.Parse(Convert.ToString(numbersList[i])));
                }
            }

            string[] currentResult = new string[0];
            string finalResult = String.Empty;
            int skipCount = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                currentResult = textList.Skip(skipCount).Take(takeList[i]).ToArray();

                skipCount += skipList[i] + takeList[i];

                finalResult += string.Join("", currentResult);
            }

            Console.WriteLine(finalResult);
        }
    }
}