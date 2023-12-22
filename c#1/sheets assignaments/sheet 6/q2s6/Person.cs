using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace q2s6
{
    internal class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public Person(int Id, string name, int age, string gender)
        {
            this.Id = Id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public void PrintPersonData()
        {
           Console.WriteLine("id is:{0} \n name is:{1} \n age is: {2} \n gender is:{3}",Id,name,age,gender);
        }
        public virtual  double PersonTax() {
            return 0;
        }
    }
    class Employee : Person
    {
        public double salary {  get; set; }
        public Employee(int id, string name, int age, string gender, double salary)
        : base(id, name, age, gender)
        {
            this.salary = salary;
        }

        public virtual  double PersonTax()
        {
            return salary*0.1;
        }

    }
    class SalesMan : Employee
    {
        public double commission { get; set; }


        public SalesMan(int id, string name, int age, string gender, double salary, double commission)
       : base(id, name, age, gender, salary)
        {
            this.commission = commission;
        }

        public override double PersonTax()
        {
            double salaryTax = base.PersonTax(); 
            double commissionTax = 0.15 * salary;
            return salaryTax + commissionTax;
        }
    }
}
