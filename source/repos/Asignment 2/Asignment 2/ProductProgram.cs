using System;
using System.Collections.Generic;
using System.Text;

namespace Asignment_2
{
    public abstract class ProductProgram 
    {
        protected string name;
        protected int price;
        public ProductProgram(string n, int p)
        {
            this.name = n;
            this.price = p;
        }
        public abstract void Add(ProductProgram p);
        public abstract void Delete(ProductProgram p);
        public abstract int CalculateTotalPrice();
    }
    
   
}
