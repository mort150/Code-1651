using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom cls = new Classroom();
            while (true)
            {
                System.Console.WriteLine("----==== System Manager ====----");
                System.Console.WriteLine("1. Add Teacher");
                System.Console.WriteLine("2. Add Student");
                System.Console.WriteLine("3. Grade for students");
                System.Console.WriteLine("4. Show all info of students and teacher");
                System.Console.WriteLine("0. Exit the program!!!");
                System.Console.WriteLine("----==== ++++++++++ ====----");
                System.Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: cls.AddTeacher(); break;
                    case 2: cls.AddStudent(); break;
                    case 3: cls.GradeStudents(); break;
                    case 4: cls.ShowInfo(); break;
                    case 0: break;
                    default: System.Console.WriteLine("Invalid choice, enter again pls!!!"); break;
                }
            }
        }
    }
}
