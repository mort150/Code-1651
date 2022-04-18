using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollPro
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Fee { get; set; }
        public string ClassName { get; set; }

        public Student(string name)
        {
            Name = name;
            ID = -1;
            Fee = false;
            ClassName = "No Class";
        }
    }
}