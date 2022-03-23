using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product
{
    public class ProductManager
    {
        private List<Product> listProducts;

        public ProductManager()
        {
            listProducts = new List<Product>();
        }
        public void AddProduct()
        {
            System.Console.WriteLine("Enter product's name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter product's price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Product p = new Product(name, price);
            listProducts.Add(p);
        }

        public void EditProduct()
        {
            //find by name
            System.Console.WriteLine("Enter product's name to find: ");
            string name = Console.ReadLine();
            Product t = FindProduct(name);
            if (t == null)
            {
                System.Console.WriteLine("Product not found!!!");
            }
            else
            {
                //edit price
                System.Console.WriteLine("Enter new product's price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                t.Price = price;
            }

        }
        public void DeleteProduct()
        {
            //find by name
            System.Console.WriteLine("Enter product's name to find: ");
            string name = Console.ReadLine();
            Product t = FindProduct(name);
            if (t == null)
            {
                System.Console.WriteLine("Product not found!!!");
            }
            else
            {
                listProducts.Remove(t);
            }
        }

        private Product FindProduct(string name)
        {
            for (int i = 0; i < listProducts.Count; i++)
            {
                if (listProducts[i].Name == name)
                {
                    return listProducts[i];
                }
            }
            return null;
        }

        public void ShowProducts()
        {
            // //C1: for traditional
            // for (int i = 0; i < listProducts.Count; i++)
            // {
            //     listProducts[i].ShowInfo();
            // }
            // C2: use foreach
            foreach (Product p in listProducts) p.ShowInfo();
        }
    }
}