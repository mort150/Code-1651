using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise
{
    public class Classroom
    {
        private List<Student> listStudents;
        Teacher teacher = new Teacher();
        public Classroom()
        {
            listStudents = new List<Student>();
        }
        public void AddStudent()
        {
            System.Console.WriteLine("Enter name of Student: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Id of Student: ");
            string id = Console.ReadLine();
            // System.Console.WriteLine("Enter grade of Student: ");
            // double grade = Convert.ToDouble(Console.ReadLine());

            Student s = new Student(name, id);
            listStudents.Add(s);
        }

        public void AddTeacher()
        {
            System.Console.WriteLine("Enter name of Teacher: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter course: ");
            string course = Console.ReadLine();

            teacher = new Teacher(name, course);
        }

        public void ShowInfo()
        {
            for (int i = 0; i < listStudents.Count; i++)
            {
                listStudents[i].StudentInfo();
            }
            teacher.TeacherInfo();
        }
        public void GradeStudents()
        {
            // foreach(Student s in listStudents) teacher.Grade(s);

            for (int i = 0; i < listStudents.Count; i++)
            {
                teacher.Grade(listStudents[i]);
            }
        }

    }
}