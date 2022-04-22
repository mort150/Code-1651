using System;

class PartTimeEmployee
{
    private int days;
    public int Days
    {
        get { return days; }
        set { days = value; }
    }
    public void ShowInfo()
    {
        Console.WriteLine("Days ; " + days);
        Console.WriteLine("ID ; " + id);
        Console.WriteLine("Rate ; " + rate);
        Console.WriteLine("Salary ; " + GetSalary());

    }
    public double GetSalary()
    {
        return rate * BASIC_SAL * days / 5;
    }
}