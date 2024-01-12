using System;

class Employee
{
    private string name;
    private double salary;

    public Employee(string name)
    {
        this.name = name;
        this.salary = 0;
    }

    public string GetName()
    {
        return name;
    }

    public double GetSalary()
    {
        return salary;
    }

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public virtual void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for employee: " + name);
    }
}

class FullTimeEmployee : Employee
{
    private double basicSalary;
    private int employmentYears;

    public FullTimeEmployee(string name) : base(name)
    {
        this.basicSalary = 1000;
        this.employmentYears = 0;
    }

    public int GetEmploymentYears()
    {
        return employmentYears;
    }

    public void SetEmploymentYears(int years)
    {
        employmentYears = years;
    }

    public override void CalculateSalary()
    {
        SetSalary(basicSalary + employmentYears * 100);
        Console.WriteLine("Full-time employee salary calculated for " + GetName() + ": " + GetSalary());
    }
}

class PartTimeEmployee : Employee
{
    private int hours;
    private double wage;

    public PartTimeEmployee(string name, int hours, double wage) : base(name)
    {
        this.hours = hours;
        this.wage = wage;
    }

    public int GetHours()
    {
        return hours;
    }

    public void SetHours(int hours)
    {
        this.hours = hours;
    }

    public double GetWage()
    {
        return wage;
    }

    public void SetWage(double wage)
    {
        this.wage = wage;
    }

    public override void CalculateSalary()
    {
        SetSalary(hours * wage);
        Console.WriteLine("Part-time employee salary calculated for " + GetName() + ": " + GetSalary());
    }
}

class Program
{
    static void Main()
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("John Doe");
        fullTimeEmployee.SetEmploymentYears(5);
        fullTimeEmployee.CalculateSalary();

        PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Jane Smith", 20, 15.5);
        partTimeEmployee.CalculateSalary();
    }
}
