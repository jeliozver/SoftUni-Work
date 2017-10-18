namespace P07_Andrey_and_Billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int stocksCount = int.Parse(Console.ReadLine());

            var shop = new Dictionary<string, decimal>();

            for (int i = 0; i < stocksCount; i++)
            {
                string[] currentItem = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                if (!shop.ContainsKey(currentItem[0]))
                {
                    shop[currentItem[0]] = 0m;
                }

                shop[currentItem[0]] = decimal.Parse(currentItem[1]);
            }

            string currentCustomer = Console.ReadLine();
            var customersList = new HashSet<Customer>();

            while (currentCustomer != "end of clients")
            {
                string[] arguments = currentCustomer
                    .Split('-', ',')
                    .ToArray();

                string customerName = arguments[0];
                string product = arguments[1];
                int quantity = int.Parse(arguments[2]);

                if (shop.ContainsKey(product))
                {
                    var customer = new Customer
                    {
                        Name = customerName,
                        ShopList = new Dictionary<string, int>(),
                        Bill = 0
                    };

                    customer.ShopList.Add(product, quantity);

                    if (customersList.Any(c => c.Name == customerName))
                    {
                        var existingCustomer = customersList.First(c => c.Name == customerName);

                        if (existingCustomer.ShopList.ContainsKey(product))
                        {
                            existingCustomer.ShopList[product] += quantity;
                        }
                        else
                        {
                            existingCustomer.ShopList[product] = quantity;
                        }
                    }
                    else
                    {
                        customersList.Add(customer);
                    }
                }

                currentCustomer = Console.ReadLine();
            }

            foreach (var customer in customersList)
            {
                foreach (var item in customer.ShopList)
                {
                    foreach (var product in shop)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            foreach (var customer in customersList.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine($"Total bill: {customersList.Sum(b => b.Bill):f2}");
        }
    }
}