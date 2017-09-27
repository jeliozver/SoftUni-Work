namespace P11_Five_Different_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            bool isCombinationFound = false;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    for (int k = firstNumber; k <= secondNumber; k++)
                    {
                        for (int s = firstNumber; s <= secondNumber; s++)
                        {
                            for (int u = firstNumber; u <= secondNumber; u++)
                            {
                                if (firstNumber <= i && i < j && j < k && k < s && s < u && u <= secondNumber)
                                {
                                    isCombinationFound = true;
                                    Console.WriteLine($"{i} {j} {k} {s} {u}");
                                }
                            }
                        }
                    }
                }
            }

            if (!isCombinationFound)
            {
                Console.WriteLine("No");
            }

        }
    }
}
