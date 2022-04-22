using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2demo
{
    public abstract class Combo
    {
        protected string name;
        protected int price;

        public string Name
        {
            get { return name;  }
            set { name = value;  }
        }
        public int Price
        {
            get { return price; }
            set {
                    if (price <= 0) throw new FormatException("The price must not be less than or equal to zero. Pls enter again!!! ");
                    else price = value;  
                }
        }
        public Combo()
        {
            name = "unknown";
            price = 1;
        }
        public Combo(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Add(Combo p);
        public abstract void Delete(Combo p);
        public abstract int CalculateTotalPrice();
    }

}
