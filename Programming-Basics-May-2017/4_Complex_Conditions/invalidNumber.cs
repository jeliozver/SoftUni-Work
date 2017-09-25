using System;

namespace Invalid_Number
{
    class invalidNumber
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0 || num >= 100 && num <= 200)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
