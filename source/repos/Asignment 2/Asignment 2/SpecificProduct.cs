using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment_2
{
    public class SpecificProduct : ProductProgram
    {
        public SpecificProduct(string name, int price)
            :base(name,price)
        {

        }
        public override void Add(ProductProgram p)
        {
            Console.WriteLine("Cannot add more products to specific product!!!");
        }
        public override void Delete(ProductProgram p)
        {
            Console.WriteLine("Cannot delete product from specific product!!!");
        }
        public override int CalculateTotalPrice()
        {
            Console.WriteLine(name + " costs " + price);
            return price;
        }
    }
}
