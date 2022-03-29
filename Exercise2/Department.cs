using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Department
    {
        private string name;
        private List<Employee> ems;
        private Employee head;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Name");
                else value = name;
            }
        }
        public Department(string name)
        {
            Name = name;
            ems = new List<Employee>();
            head = new Employee();
        }
        public void AddEmployee(Employee em)
        {
            ems.Add(em);
        }
        public void AssignHead(Employee he)
        {
            head = he;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Department " + name);
            System.Console.WriteLine("------==================-----------");
            System.Console.WriteLine("----------Employees-----------");
            foreach(Employee em in ems) em.EmployeeInfo();
            System.Console.WriteLine("----------Head-----------");
            head.EmployeeInfo();
        }
    }
}