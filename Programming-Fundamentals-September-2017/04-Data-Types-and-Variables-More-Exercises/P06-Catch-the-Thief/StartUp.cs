namespace P06_Catch_the_Thief
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

            Console.WriteLine(thiefId);
        }
    }
}