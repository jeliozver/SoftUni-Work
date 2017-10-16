namespace P06_Rectangle_Position
{
    using System;
    using System.Linq;
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right => Left + Width;
        public int Bottom => Top + Height;

    }

    public class StartUp
    {
        public static void Main()
        {
            var first = ReadRectangle();
            var second = ReadRectangle();

            Console.WriteLine(IsFirstInsideSecond(first, second) 
                ? "Inside" 
                : "Not inside");
        }

        public static bool IsFirstInsideSecond(
            Rectangle first, Rectangle second)
        {
            bool testOne = first.Left >= second.Left;
            bool testTwo = first.Right <= second.Right;
            bool testThree = first.Top <= second.Top;
            bool testFour = first.Bottom <= second.Bottom;

            return testOne && testTwo && testThree && testFour;
        }

        public static Rectangle ReadRectangle()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            var rectangle = new Rectangle
            {
                Left = input[0],
                Top =  input[1],
                Width = input[2],
                Height = input[3]
            };

            return rectangle;
        }
    }
}