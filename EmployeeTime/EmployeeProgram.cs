using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTime
{
    public class EmployeeProgram : MenuProgram
    {
        private  List<Employee> emps;
        public EmployeeProgram()
        {
            emps = new List<Employee>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("--------- Menu program --------");
            System.Console.WriteLine("1. Add FullTime");
            System.Console.WriteLine("2. Add PartTime");
            System.Console.WriteLine("3. Add Saler");
            System.Console.WriteLine("4. Display all employees");
            System.Console.WriteLine("0. Exit");

        }
        protected override void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: AddFullTime(); break;
                case 2: AddPartTime(); break;
                case 3: AddSale(); break;
                case 4: ShowAll(); break;
                case 0: System.Console.WriteLine("You've been out of the program!!!"); break;
                default: System.Console.WriteLine("Invalid choice!!!"); break;
            }
        }
        private void AddFullTime()
        {
            System.Console.WriteLine("Enter the name of FullTime's employee: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the age of FullTime's employee: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Rate of FullTime's employee: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Employee f = new FullTime(name, age, rate);
            emps.Add(f);
        }
        private void AddPartTime()
        {
            System.Console.WriteLine("Enter the name of PartTime's employee: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the age of PartTime's employee: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Rate of PartTime's employee: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter day(s) of PartTime's employee: ");
            int days = Convert.ToInt32(Console.ReadLine());

            Employee p = new PartTime(name, age, rate, days);
            emps.Add(p);
        }
        private void AddSale()
        {
            System.Console.WriteLine("Enter the name of Saler's employee: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the age of Saler's employee: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the Rate of Saler's employee: ");
            double commission = Convert.ToDouble(Console.ReadLine());

            Employee s = new Sale(name, age, commission);
            emps.Add(s);
        }
        private void ShowAll()
        {
            foreach(Employee e in emps)
            {
                System.Console.WriteLine(e);
            }
        }
    }
}