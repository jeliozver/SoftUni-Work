namespace P08_Personal_Exception
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    try
                    {
                        throw new NegativeNumberException();
                    }
                    catch (NegativeNumberException)
                    {
                        Console.WriteLine("My first exception is awesome!!!");
                        return;
                    }
                }

                Console.WriteLine(number);
            }
        }
    }
}