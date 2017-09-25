using System;

namespace Speed_Info
{
    class speedInfo
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());

            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else if (speed > 150)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 50)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 10)
            {
                Console.WriteLine("average");
            }
            else
            {
                Console.WriteLine("slow");
            }
        }
    }
}
