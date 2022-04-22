using System;

public class Employee
{
    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    protected static int nEmployee = 0;
    protected int id;
    public int ID
    {
        get { return id; }
    }

    protected double rate;
    public double Rate
    {
        get { return rate; }
        set { rate = value; }
    }
    protected const double BASIC_SAL = 1000;
    public Employee()
    {
        name = "unknown";
        rate = 1.0;
        id = nEmployee;
        nEmployee++;
    }
    public Employee(string name, double rate)
    {
        Name = name;
        Rate = rate;
        id = nEmployee++;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name ; " + name);
        Console.WriteLine("ID ; " + id);
        Console.WriteLine("Rate ; " + rate);
        Console.WriteLine("Salary ; " + GetSalary());

    }
    public double GetSalary()
    {
        return rate * BASIC_SAL;
    }
}