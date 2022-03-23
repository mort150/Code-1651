using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product
{
    public class Product
    {
        private string name;
        private int price;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    System.Console.WriteLine("Invalid product name!!!");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    System.Console.WriteLine("Invalid product price!!!");
                }
                else
                {
                    price = value;
                }
            }
        }

        public Product()
        {
            name = "unknown";
            price = 1;
        }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Product: " + name);
            System.Console.WriteLine("Price: " + price);
        }
    }
}