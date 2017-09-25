using System;

namespace PassionDays
{
    class PassionDays
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int purchases = 0;
            decimal price = 0;

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();

            }

            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                foreach (char action in command)
                {
                    if (action == '%' && money != 0)
                    {
                        price = money / 2.0m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (action == '*')
                    {
                        money += 10.0m;
                    }
                    else if (action >= 'a' && action <= 'z')
                    {
                        price = action * 0.3m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (action >= 'A' && action <= 'Z')
                    {
                        price = action * 0.5m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else
                    {
                        price = action;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                }

                command = Console.ReadLine();
            }

            if (purchases == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchases} purchases. Money left: {money:f2} lv.");
            }
        }
    }
}