using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise
{
    public class Teacher
    {
        private string name;
        private string course;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Name!!!");
                else name = value;
            }
        }
        public string Course
        {
            get { return course; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid Course!!!");
                else course = value;
            }
        }

        public Teacher()
        {
            name = "Teacher 1";
            course = "GCH001";
        }
        public Teacher(string name, string course)
        {
            Name = name;
            Course = course;
        }
        public void TeacherInfo()
        {
            System.Console.WriteLine("Teacher's name: " + name);
            System.Console.WriteLine("Course: " + course);
        }

        public void Grade(Student s)
        {
            System.Console.WriteLine("Enter the grade for student: " + s.Name);
            double grade = Convert.ToDouble(Console.ReadLine());

            s.Grade = grade;
        }
    }
}