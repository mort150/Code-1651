using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTime
{
    public class PartTime : FullTime
    {
        public int Days { get; set; }

        public PartTime() : base()
        {   
            Days = 1;
        }
        public PartTime(string name, int age, double rate, int days) : base(name, age, rate)
        {
            Days = days;
        }
        public override double Salary()
        {
            return Rate * BASIC_SA * Days / 5;
        }
    }
}