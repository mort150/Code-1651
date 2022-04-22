using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2demo
{
    public class Cart : ProductProgram
    {
        private List<ProductProgram> products;
        public Cart(string name, int price)
            : base(name, price)
        {
            products = new List<ProductProgram>();
        }

        public override void Add(ProductProgram p)
        {
            products.Add(p);
        }
        public override void Delete(ProductProgram p)
        {
            products.Remove(p);
        }
        public override int CalculateTotalPrice()
        {
            int total = 0;
            Console.WriteLine(name + " contains the following products with price: ");
            foreach (ProductProgram p in products)
            {
                total += p.CalculateTotalPrice();
            }
            return total;

        }
    }
}
