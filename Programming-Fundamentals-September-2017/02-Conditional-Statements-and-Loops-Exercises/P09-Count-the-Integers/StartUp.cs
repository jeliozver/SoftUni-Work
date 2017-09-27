namespace P09_Count_the_Integers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numbersCount = 0;

            try
            {
                while (numbersCount < 100)
                {
                    int n = int.Parse(Console.ReadLine());
                    numbersCount++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(numbersCount);
            }
        }
    }
}
