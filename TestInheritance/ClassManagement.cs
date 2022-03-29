using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInheritance
{
    public class ClassManagement 
    {
        private Classroom cls;

        public ClassManagement()
        {
            System.Console.WriteLine("Enter the name of Class: ");
            string name = Console.ReadLine();

            cls = new Classroom(name);
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
            System.Console.WriteLine("------ Class Management ------");
            System.Console.WriteLine("1. Add Students");
            System.Console.WriteLine("2. Add Teacher");
            System.Console.WriteLine("3. Show all infomation");
            System.Console.WriteLine("0. Exit the program");
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
                case 1: AddStudents(); break;
                case 2: AssignTeacher(); break;
                case 3: ShowInfo(); break;
                case 0: System.Console.WriteLine("You've been out of the program"); break;
                default: System.Console.WriteLine("Invalid choice, pls check again!!!"); break;
            }
        }
        private void AddStudents()
        {
            System.Console.WriteLine("Enter the name of Student: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the age of Student: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the grade of Student: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            Student s = new Student(name, age, grade);
            cls.AddStudents(s);
            s.ShowInfo();
        }
        private void AssignTeacher()
        {
            System.Console.WriteLine("Enter the name of Teacher: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the age of Teacher: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the course: ");
            string course = Console.ReadLine();

            Teacher t = new Teacher(name, age, course);
            cls.AssignTeacher(t);
            t.ShowInfo();
        }
        private void ShowInfo()
        {
            cls.ShowInfo();
        }
    }
}