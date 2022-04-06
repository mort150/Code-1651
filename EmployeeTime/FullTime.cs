using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTime
{
    public class FullTime : Employee
    {
        public double Rate { get; set; }

        public FullTime() : base()
        {
            Rate = 1000;
        }
        public FullTime(string name, int age, double rate) : base(name, age)
        {
            Rate = rate;
        }

        public override double Salary()
        {
            // throw new NotImplementedException();
            return Rate * BASIC_SA;
        }
    }
}