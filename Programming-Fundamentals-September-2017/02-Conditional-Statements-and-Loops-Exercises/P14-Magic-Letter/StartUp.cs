namespace P14_Magic_Letter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == thirdLetter || j == thirdLetter || k == thirdLetter)
                        {

                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
