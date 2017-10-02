namespace P10_Centuries_to_Nanoseconds
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
            ulong minutes = (ulong)hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            decimal nanoseconds = (decimal)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days" +
                              $" = {hours} hours = {minutes} minutes = {seconds} seconds" +
                              $" = {milliseconds} milliseconds = {microseconds} microseconds" +
                              $" = {nanoseconds} nanoseconds");
        }
    }
}