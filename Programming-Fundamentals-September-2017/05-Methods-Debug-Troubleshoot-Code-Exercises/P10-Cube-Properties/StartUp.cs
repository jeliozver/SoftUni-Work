namespace P10_Cube_Properties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string actionToCalculate = Console.ReadLine();

            if (actionToCalculate == "face")
            {
                Console.WriteLine($"{CalcCubeFaceDiagonals(cubeSide):f2}");
            }
            else if (actionToCalculate == "space")
            {
                Console.WriteLine($"{CalcCubeSpaceDiagonals(cubeSide):f2}");
            }
            else if (actionToCalculate == "volume")
            {
                Console.WriteLine($"{CalcCubeVolume(cubeSide):f2}");
            }
            else if (actionToCalculate == "area")
            {
                Console.WriteLine($"{CalcCubeArea(cubeSide):f2}");
            }
        }

        public static double CalcCubeFaceDiagonals(double side)
        {
            double cubeFaceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            return cubeFaceDiagonals;
        }

        public static double CalcCubeSpaceDiagonals(double side)
        {
            double cubeSpaceDiagonals =  Math.Sqrt(3 * Math.Pow(side, 2));
            return cubeSpaceDiagonals;
        }

        public static double CalcCubeVolume(double side)
        {
            double cubeVolume = Math.Pow(side, 3);
            return cubeVolume;
        }

        public static double CalcCubeArea(double side)
        {
            double cubeArea = 6 * Math.Pow(side, 2);
            return cubeArea;
        }
    }
}