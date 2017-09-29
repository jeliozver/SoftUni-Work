namespace P08_Refactor_Volume_of_Pyramid
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double pyramidVolume = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {pyramidVolume:f2}");
        }
    }
}
