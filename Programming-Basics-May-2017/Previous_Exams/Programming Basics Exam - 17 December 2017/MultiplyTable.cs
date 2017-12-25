namespace PB_Dec_2_2017_6_Multiply_Table
{
    using System;

    public class MultiplyTable
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            for (int i = 1; i <= int.Parse(number[2].ToString()); i++)
            {
                for (int j = 1; j <= int.Parse(number[1].ToString()); j++)
                {
                    for (int k = 1; k <= int.Parse(number[0].ToString()); k++)
                    {
                        int l = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {l};");
                    }
                }
            }
        }
    }
}