using System;

namespace Rectangle_of_10x10_Stars
{
    class rectangle10Stars
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}