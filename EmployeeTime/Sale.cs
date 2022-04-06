using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTime
{
    public class Sale : Employee
    {
        public int Products { get; set; }
        public double Commission { get; set; }

        public Sale() : base()
        {
            Products = 0;
            Commission = 0.01;
        }
        public Sale(string name, int age, double commission) : base(name, age)
        {
            Products = 0;
            Commission = commission;
        }

        public void SaleProducts()
        {
            System.Console.WriteLine("How many products did you sell? ");
            Products = Convert.ToInt32(Console.ReadLine());
        }
        public override double Salary()
        {
            SaleProducts();
            // throw new NotImplementedException();
            return Products * Commission + BASIC_SA * Commission;
        }
    }
}