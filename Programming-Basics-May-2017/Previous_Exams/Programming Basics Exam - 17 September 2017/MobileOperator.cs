using System;

namespace PB_Sep_2_2017_3_Mobile_Operator
{
    class MobileOperator
    {
        static void Main(string[] args)
        {
            string contractLenght = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internetYesNo = Console.ReadLine();
            int monthsToPay = int.Parse(Console.ReadLine());

            double totalSum = 0.00;

            if (contractLenght == "one")
            {
                if (contractType == "Small")
                {
                    totalSum += 9.98;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum *= monthsToPay;
                }
                else if (contractType == "Middle")
                {
                    totalSum += 18.99;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum *= monthsToPay;
                }
                else if (contractType == "Large")
                {
                    totalSum += 25.98;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum *= monthsToPay;
                }
                else if (contractType == "ExtraLarge")
                {
                    totalSum += 35.99;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum *= monthsToPay;
                }
            }

            else
            {
                if (contractType == "Small")
                {
                    totalSum += 8.58;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum = totalSum - (totalSum * 0.0375);
                    totalSum *= monthsToPay;
                }
                else if (contractType == "Middle")
                {
                    totalSum += 17.09;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum = totalSum - (totalSum * 0.0375);
                    totalSum *= monthsToPay;
                }
                else if (contractType == "Large")
                {
                    totalSum += 23.59;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum = totalSum - (totalSum * 0.0375);
                    totalSum *= monthsToPay;
                }
                else if (contractType == "ExtraLarge")
                {
                    totalSum += 31.79;
                    if (internetYesNo == "yes")
                    {
                        if (totalSum <= 10.00)
                        {
                            totalSum += 5.50;
                        }
                        else if (totalSum <= 30.00)
                        {
                            totalSum += 4.35;
                        }
                        else
                        {
                            totalSum += 3.85;
                        }
                    }

                    totalSum = totalSum - (totalSum * 0.0375);
                    totalSum *= monthsToPay;
                }
            }

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}