using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Employee
    {
        private static int count;
        private int id;
        private string name;
        private double salary;

        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Name");
                else name = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0) System.Console.WriteLine("Invalid Salary!!!");
                else salary = value;
            }
        }
        public Employee()
        {
            id = count++;
            name = "Unknown";
            salary = 0.0;
        }
        public Employee(string name, double salary)
        {
            id = count++;
            Name = name;
            Salary = salary;
        }
        public void EmployeeInfo()
        {
            System.Console.WriteLine("Employee'ID: " + id);
            System.Console.WriteLine("Employee'name: " + name);
            System.Console.WriteLine("Employee'salary: " + salary);
            System.Console.WriteLine("*****************");
        }
    }
}