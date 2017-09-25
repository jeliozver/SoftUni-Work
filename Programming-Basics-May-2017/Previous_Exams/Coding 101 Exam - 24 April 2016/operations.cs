using System;

namespace PB_April_2016_3_Operations
{
    class operations
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double result = 0;

            if (oper == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, oper, num2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, oper, num2, result);
                }
            }
            else if (oper == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, oper, num2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, oper, num2, result);
                }
            }
            else if (oper == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", num1, oper, num2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", num1, oper, num2, result);
                }
            }
            else if (oper == "/")
            {
                result = num1 / num2;

                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3:f2}", num1, oper, num2, result);
                }
            }
            else if (oper == "%")
            {
                result = num1 % num2;
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", num1, oper, num2, result);
                }
            }
        }
    }
}
