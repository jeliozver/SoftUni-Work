using System;

namespace Cinema
{
    class cinema
    {
        static void Main(string[] args)
        {
            string priceType = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double places = rows * cols;

            switch (priceType)
            {
                case "premiere":Console.WriteLine("{0:F2} leva", places * 12.00);break;
                case "normal":Console.WriteLine("{0:F2} leva", places * 7.50);break;
                case "discount":Console.WriteLine("{0:F2} leva", places * 5.00);break;
            }
        }
    }
}
