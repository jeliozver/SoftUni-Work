namespace P01_Centuries_to_Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

           int years = centuries * 100;
           int days = (int)(years * 365.2422);
           int hours = days * 24;
           int minutes = hours * 60;

            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}
