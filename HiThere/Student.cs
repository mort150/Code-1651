using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiThere
{
    public class Student
    {
        public string name;
        private double grade;
        private int age;

        public int Age{
            get{
                return age;
            }
            set{
                age = value;
            }
        }
        public double Grade{
            get{
                return grade;
            }
            set{
                grade = value;
            }
        }

        public Student() {
            name = "Unknown";
            grade = 0.0;
            age = 18;
        }
        public Student(string name, double grade, int age){
            this.name = name;
            this.grade = grade;
            this.age = age;
        }

        public void Print(){
            System.Console.WriteLine("Student's name: " + name);
            System.Console.WriteLine("Student's age: " + age);
            System.Console.WriteLine("Student's grade: " + grade);
            System.Console.WriteLine("----===================----");
        }
    }
}