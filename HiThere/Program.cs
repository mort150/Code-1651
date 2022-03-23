using System;

namespace HiThere
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Print();

            Student s2 = new Student("Duong Tien Thanh", 9.5, 21);
            s2.Print();

            Student s3 = new Student();
            s3.name = "Duong Hoang Anh";
            s3.Age = 19;
            s3.Grade = 5.5;
            s3.Print();
        }
    }
}
