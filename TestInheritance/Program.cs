using System;

namespace TestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student s1 = new Student("Duong Tien Thanh", 18, 8.5);
            // s1.ShowInfo();

            // Teacher t1 = new Teacher("Doan Trung Tung", 25, "GCH0905");
            // t1.ShowInfo();
            // ClassManagement cls = new ClassManagement();
            // cls.Run();

            Person s = new Person();
            s.ShowInfo();

            s = new Student();
            s.ShowInfo();

            s = new Teacher();
            s.ShowInfo();
        }
    }
}
