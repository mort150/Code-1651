using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class Teacher : Person
    {
        private string course;
        public string Course
        {
            get { return course; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid course!!!");
                else course = value;
            }
        }
        public Teacher() : base("Unknown", 25)
        {
            course = "GCH001";
        }
        public Teacher(string name, int age, string course) : base(name, age)
        {
            Course = course;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Teacher's course: " + course);
        }
    }
}