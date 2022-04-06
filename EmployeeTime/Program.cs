using System;

namespace EmployeeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee emp = new FullTime("John", 20, 1.0);
            // System.Console.WriteLine(emp);

            // emp = new PartTime("Mort", 18, 1.0, 2);
            // System.Console.WriteLine(emp);

            // emp = new Sale("Tom", 22, 0.01);
            // System.Console.WriteLine(emp);

            EmployeeProgram emp = new EmployeeProgram();
            emp.Run();
        }
    }
}
