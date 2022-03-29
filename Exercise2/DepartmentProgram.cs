using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class DepartmentProgram
    {
        private Department dept;
        public DepartmentProgram()
        {
            System.Console.WriteLine("Enter Department'name: ");
            string name = Console.ReadLine();


            dept = new Department(name);
        }
        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }
        private void PrintMenu()
        {
            System.Console.WriteLine("------Department Manager---------");
            System.Console.WriteLine("1. Add Employee");
            System.Console.WriteLine("2. Assign Head");
            System.Console.WriteLine("3. Show all information");
            System.Console.WriteLine("0. Add Exit");

        }
        private int GetChoice()
        {
            System.Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        private void DoTask(int choice)
        {
            switch(choice)
            {
                case 1: AddEmployee(); break;
                case 2: AssignHead(); break;
                case 3: ShowInfo(); break;
                case 0: System.Console.WriteLine("You've been out of the system"); break;
                default: System.Console.WriteLine("Invalid choice!!!"); break;
            }
        }
        private void AddEmployee()
        {
            System.Console.WriteLine("Enter Employee'name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee em = new Employee(name, salary);
            dept.AddEmployee(em);
            em.EmployeeInfo();
        }
        private void AssignHead()
        {
            System.Console.WriteLine("Enter Head'name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Head's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Employee he = new Employee(name, salary);
            dept.AssignHead(he);
            he.EmployeeInfo();
        }
        private void ShowInfo()
        {
            dept.ShowInfo();
        }
    }
}