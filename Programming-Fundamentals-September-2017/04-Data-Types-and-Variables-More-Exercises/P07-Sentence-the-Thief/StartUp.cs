namespace P07_Sentence_the_Thief
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string idType = Console.ReadLine();
            int interval = int.Parse(Console.ReadLine());

            long currentThiefId = 0;
            long thiefId = long.MinValue;

            for (int i = 1; i <= interval; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (idType == "sbyte")
                {
                    if (id >= sbyte.MinValue && id <= sbyte.MaxValue)
                    {
                        currentThiefId = id;
                        thiefId = Math.Max(currentThiefId, thiefId);
                    }
                }
                else if (idType == "int")
                {
                    if (id >= int.MinValue && id <= int.MaxValue)
                    {
                        currentThiefId = id;
                        thiefId = Math.Max(currentThiefId, thiefId);
                    }
                }
                else if (idType == "long")
                {
                    if (id >= long.MinValue && id <= long.MaxValue)
                    {
                        currentThiefId = id;
                        thiefId = Math.Max(currentThiefId, thiefId);
                    }
                }
            }

            decimal thiefSentence = 0;

            if (thiefId < 0)
            {
                thiefSentence = Math.Ceiling((decimal)thiefId / -128);
            }
            else
            {
                thiefSentence = Math.Ceiling((decimal)thiefId / 127);
            }

            if (thiefSentence == 1)
            {
                Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {thiefSentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {thiefSentence} years");
            }
        }
    }
}