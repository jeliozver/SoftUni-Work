namespace P07_Andrey_and_Billiard
{
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }
    }
}