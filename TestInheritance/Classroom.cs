using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class Classroom
    {
        private string name;
        private List<Student> students;
        private Teacher teacher;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") System.Console.WriteLine("Invalid name!!!");
                else name = value;
            }
        }
        public Classroom(string name)
        {
            students = new List<Student>();
            teacher = new Teacher();

            Name = name;
        }
        public void AddStudents(Student s)
        {
            students.Add(s);
        }
        public void AssignTeacher(Teacher t)
        {
            teacher = t;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine("Students in this class: " + name);
            if(students.Count == 0) System.Console.WriteLine("This class doesn't have any student(s)!!!");
            else foreach(Student s in students) s.ShowInfo();
            System.Console.WriteLine("+++++++++++++++++++++");
            System.Console.WriteLine("Teacher in this class: " + name);
            if(teacher == null) System.Console.WriteLine("This class doesn't have teacher yet, pls add teacher first!!!");
            else teacher.ShowInfo();          
        }
    }
}