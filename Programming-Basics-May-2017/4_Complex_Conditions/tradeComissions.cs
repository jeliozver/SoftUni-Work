using System;

namespace Trade_Comissions
{
    class tradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comission = -1.0;
            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.05;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.07;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.08;
                }
                else if (sales > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.045;
                }
                else if (500 < sales && sales <= 1000)
                {
                    comission = 0.075;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.10;
                }
                else if (sales > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = 0.055;
                }
                else if (500 < sales && sales <= 5000)
                {
                    comission = 0.08;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    comission = 0.12;
                }
                else if (sales > 10000)
                {
                    comission = 0.145;
                }
            }

            if (comission == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:F2}", comission * sales);
            }
        }
    }
}