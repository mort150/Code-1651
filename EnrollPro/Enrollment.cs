using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollPro
{
    public abstract class Enrollment
    {
        public Enrollment Next { get; set; }
        public abstract void Enroll(Student s);
    }
    public class Accounter : Enrollment
    {
        public override void Enroll(Student s)
        {
            System.Console.WriteLine("Enroll fee is $499!");
            System.Console.WriteLine("Do you want to enroll? (y/n)");
            string a = Console.ReadLine().ToLower();
            if (a == "y")
            {
                s.Fee = true;
                System.Console.WriteLine("Student Paid Fee! Go to Academic Staff");
                Console.ReadLine();
                Next.Enroll(s);
            }
            else
            {
                System.Console.WriteLine("Not Enrolled!!!");
            }
        }
    }
    public class AcademicStaff : Enrollment
    {
        private int count = 0;
        public override void Enroll(Student s)
        {
            if (s.Fee == false)
            {
                System.Console.WriteLine("Student do not pay fee!!!");
                return;
            }
            s.ID = count++;
            System.Console.Write("Enter class's name: ");
            string Classname = Console.ReadLine();
            s.ClassName = Classname;

            System.Console.WriteLine("Student Enrolled!!!");
            System.Console.WriteLine("Student's ID: " + s.ID);
            System.Console.WriteLine("Student's Name: " + s.Name);
            System.Console.WriteLine("Next is Scheduler ... ");
            Console.ReadLine();

            Next.Enroll(s);
        }
    }
    public class Scheduler : Enrollment
    {
        private List<FGWClass> classes = new List<FGWClass>();
        public void AddClass(FGWClass c)
        {
            classes.Add(c);
        }
        public override void Enroll(Student s)
        {
            if (s.ClassName == "No Class")
            {
                System.Console.WriteLine("Student did not enroll!!!");
                return;
            }
            foreach (FGWClass c in classes)
            {
                if (c.Name == s.ClassName)
                {
                    c.AddStudent(s);
                    System.Console.WriteLine("Student enrolled in class " + c.Name);
                    System.Console.WriteLine("ClassTime: " + c.ClassTime);
                    System.Console.WriteLine("Student in class: ");
                    foreach (Student st in c.Students)
                    {
                        System.Console.WriteLine("\t" + st.Name);
                    }
                    return;
                }
            }
            System.Console.WriteLine("Enrollment completed!!!");
        }
    }
}