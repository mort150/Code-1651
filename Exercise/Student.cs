using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise
{
    public class Student
    {
        private string name;
        private string id;
        private double grade;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Name!!!");
                else name = value;
            }
        }
        public string Id
        {
            get { return id; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Id!!!");
                else id = value;
            }
        }
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 0) System.Console.WriteLine("Invalid Grade!!!");
                else grade = value;
            }
        }
        public Student()
        {
            name = "Unknown";
            id = "GCH01";
            grade = 0.0;
        }

        public Student(string name, string id)
        {
            Name = name;
            Id = id;
            Grade = 0.0;
        }

        public void StudentInfo()
        {
            System.Console.WriteLine("Student's name: " + name);
            System.Console.WriteLine("Student's Id: " + id);
            System.Console.WriteLine("Student's Grade: " + grade);
            System.Console.WriteLine("***********");
        }
    }
}