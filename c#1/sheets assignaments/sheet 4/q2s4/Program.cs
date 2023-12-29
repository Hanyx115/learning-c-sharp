using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2s4
{
    public class employee
    {
        public class Employee
        {
            private int employeeNumber;
            private string name;
            private DateTime dateOfHire;
            private decimal monthlySalary;
            public Employee(int employeeNumber, string name, DateTime dateOfHire, decimal monthlySalary)
            {
                this.employeeNumber = employeeNumber;
                this.name = name;
                this.dateOfHire = dateOfHire;
                this.monthlySalary = monthlySalary;
            }
            public int EmployeeNumber
            {
                get { return employeeNumber; }
                set { employeeNumber = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public DateTime DateOfHire
            {
                get { return dateOfHire; }
                set { dateOfHire = value; }
            }
            public decimal MonthlySalary
            {
                get { return monthlySalary; }
                set { monthlySalary = value; }
            }
            public string ConvertToString()
            {
                return $"Employee Number: {employeeNumber}, Name: {name}, Date of Hire: {dateOfHire}, Monthly Salary: {monthlySalary:C}";
            }
            public decimal CalculateTax()
            {
                return 0.1m * monthlySalary;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
