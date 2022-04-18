using System;

namespace EnrollPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //create 3  - 5 students
            Student s1 = new Student("John");
            Student s2 = new Student("Mort");
            Student s3 = new Student("Mary");
            Student s4 = new Student("Same");
            Student s5 = new Student("Peter");
            //create 2 classes fgw, add students onto classes
            FGWClass c1 = new FGWClass("Math", "8:00am");
            c1.AddStudent(s1);
            c1.AddStudent(s2);
            c1.AddStudent(s3);

            FGWClass c2 = new FGWClass("Science", "10:00am");
            c2.AddStudent(s4);
            c2.AddStudent(s5);
            //create scheduler, add classes to scheduler
            Scheduler scheduler = new Scheduler();
            scheduler.AddClass(c1);
            scheduler.AddClass(c2);
            //create academic staff, set next to scheduler
            AcademicStaff academicStaff = new AcademicStaff();
            academicStaff.Next = scheduler;
            //create accounter, set next to acadamic staff
            Accounter accounter = new Accounter();
            accounter.Next = academicStaff;

            //enroll new Student
            
            //ask student name
            System.Console.Write("Enter student's name: ");
            string name = Console.ReadLine();
            //create new student
            Student newStu = new Student(name);
            //call enroll method from accounter
            accounter.Enroll(newStu);
        }
    }
}
