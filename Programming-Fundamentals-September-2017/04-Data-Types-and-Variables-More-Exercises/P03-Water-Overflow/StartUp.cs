namespace P03_Water_Overflow
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());

            byte waterTankCapacity = 0;

            for (byte i = 0; i < numberOfLines; i++)
            {
                short litersToAdd = short.Parse(Console.ReadLine());

                if (waterTankCapacity + litersToAdd > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTankCapacity += (byte)litersToAdd;
                }
            }

            Console.WriteLine(waterTankCapacity);
        }
    }
}