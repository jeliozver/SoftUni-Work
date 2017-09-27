namespace P04_Photo_Gallery
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int sizeInBytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double sizeConverted = 0.0;
            string orientation = string.Empty;
            string sizeType = string.Empty;

            if (sizeInBytes < 1000)
            {
                sizeConverted = sizeInBytes;
                sizeType = "B";
            }
            else if (sizeInBytes < 1000000)
            {
                sizeConverted = (double)sizeInBytes / 1000;
                sizeType = "KB";
            }
            else
            {
                sizeConverted = (double)sizeInBytes / 1000000;
                sizeType = "MB";
            }

            if (width == height)
            {
                orientation = "square";
            }
            else if (width > height)
            {
                orientation = "landscape";
            }
            else
            {
                orientation = "portrait";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minute:d2}");
            Console.WriteLine($"Size: {sizeConverted}{sizeType}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
