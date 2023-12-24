using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twelfth_exam
{
    internal class person
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        public person()
        { 
        
        }
        public person(string name)
        {
            this.name = name;
        }
        public virtual string Greet() 
        {
            return string.Empty;
        
        }
        public virtual string SayBye() 
        {
            return "Goodbye";
        }
        
    }
    internal class Teacher : person
    {
        private int NumberOfCourses;
        private double salary;
        public Teacher(int numberofcourses, double salary, string Name) : base(Name)
        {
            this.NumberOfCourses = numberofcourses;
            this.salary = salary;
        }
        public override string Greet()
        {
            return "Hello Students!";
        }
        public void teach(int numberofcourses)
        {
            Console.WriteLine("I Have To Teach"+ numberofcourses+"this semester");
        }

    }
    internal class Student : person
    {
        private double GPA;
        public Student(double GPA,string name):base (name)
        {
            this. GPA = GPA;

        }
        public override string Greet()
        {
            return "Hello Teacher";
        }
        public void learn() 
        {
            Console.WriteLine("I still have courses to finish!"); 
        }
    }
}
