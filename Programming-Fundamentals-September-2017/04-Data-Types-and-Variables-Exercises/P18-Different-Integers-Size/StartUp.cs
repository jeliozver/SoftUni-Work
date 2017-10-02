namespace P18_Different_Integers_Size
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
           
            try
            {
                long test = long.Parse(number);
                Console.WriteLine($"{number} can fit in:");

                if (test >= sbyte.MinValue && test <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (test >= byte.MinValue && test <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (test >= short.MinValue && test <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (test >= ushort.MinValue && test <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (test >= int.MinValue && test <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (test >= uint.MinValue && test <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (test >= long.MinValue && test <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}