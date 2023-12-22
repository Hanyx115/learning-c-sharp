using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2s6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "John Doe", 30, "Male");
            person.PrintPersonData();
            Console.WriteLine($"Tax: {person.PersonTax()}");

            Employee employee = new Employee(2, "Jane Doe", 25, "Female", 50000);
            employee.PrintPersonData();
            Console.WriteLine($"Tax: {employee.PersonTax()}");

            SalesMan salesman = new SalesMan(3, "Bob Smith", 35, "Male", 60000, 2000);
            salesman.PrintPersonData();
            Console.WriteLine($"Tax: {salesman.PersonTax()}");
        }
    }
}
