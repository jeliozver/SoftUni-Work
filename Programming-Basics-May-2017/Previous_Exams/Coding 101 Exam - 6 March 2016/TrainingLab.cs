using System;

namespace PB_March_2016_1_Training_Lab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var heigh = double.Parse(Console.ReadLine());

            var widthPlaces = Math.Truncate((width * 100) / 120);
            var heighPlaces = Math.Truncate((heigh * 100 - 100) / 70);
            var places = widthPlaces * heighPlaces - 3;

            Console.WriteLine(places);
        }
    }
}
