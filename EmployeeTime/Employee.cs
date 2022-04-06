using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTime
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public const double BASIC_SA = 1000;

        public Employee()
        {
            Name = "Employee";
            Age = 18;
        }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract double Salary();

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Salary: " + Salary();
        }
    }
}