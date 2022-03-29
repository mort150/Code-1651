using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class Student : Person
    {
        private double grade;
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 0.0 || value > 10.0) System.Console.WriteLine("Invalid grade!!!");
                else grade = value;
            }
        }
        public Student() : base("Student", 18)
        {
            grade = 0.0;
        }
        public Student(string name, int age, double grade) : base(name, age)
        {
            Grade = grade;
        }
        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Student's Grade: " + grade);
        }
    }
}