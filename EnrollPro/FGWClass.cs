using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollPro
{
    public class FGWClass
    {
        private List<Student> students;
        public List<Student> Students
        {
            get
            {
                return students;
            }
        }
        public string Name { get; set; }
        public string ClassTime { get; set; }
        public FGWClass(string name, string classTime)
        {
            Name = name;
            ClassTime = classTime;
            students = new List<Student>();
        }
        public void AddStudent(Student s)
        {
            students.Add(s);
        }
    }
}