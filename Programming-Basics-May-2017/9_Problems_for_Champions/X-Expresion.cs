using System;

namespace X_Expresion
{
    class XExpresion
    {
        static void Main(string[] args)
        {
            int symbol = Console.Read();

            decimal result = 0;
            int expressionOperator = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    symbol = Console.Read();
                    decimal innerResult = 0;
                    int innerOperator = '+';

                    while (symbol != ')')
                    {
                        if (0 <= symbol - 48 && symbol - 48 <= 9)
                        {
                            switch (innerOperator)
                            {
                                case '+': innerResult += symbol - 48; break;
                                case '-': innerResult -= symbol - 48; break;
                                case '*': innerResult *= symbol - 48; break;
                                case '/': innerResult /= symbol - 48; break;
                            }
                        }
                        else if (symbol == '+' || symbol == '-' || symbol == '/' || symbol == '*')
                        {
                            innerOperator = symbol;
                        }

                        symbol = Console.Read();
                    }

                    switch (expressionOperator)
                    {
                        case '+': result += innerResult; break;
                        case '-': result -= innerResult; break;
                        case '*': result *= innerResult; break;
                        case '/': result /= innerResult; break;
                    }
                }
                else if (0 <= symbol - 48 && symbol - 48 <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+': result += symbol - 48; break;
                        case '-': result -= symbol - 48; break;
                        case '*': result *= symbol - 48; break;
                        case '/': result /= symbol - 48; break;
                    }
                }
                else if (symbol == '+' || symbol == '-' || symbol == '/' || symbol == '*')
                {
                    expressionOperator = symbol;
                }

                symbol = Console.Read();
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}