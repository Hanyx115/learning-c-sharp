using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Electronics_store
{
    class Person
    {
        private string name;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age > 17)
                {
                    age = value;
                }
                else
                    Console.WriteLine("must be older then 18");
            }

        }



        public Person(string n, int a)
        {
            name = n;
            age = a;

        }



    }

    class Address
    {
        private string streetname;
        private double streetnum;
        private int floornum;
        private int flatnum;
        private string city;




        public Address() { }

        public Address(string stname, double stnum, int flnum, int num, string c)
        {
            streetname = stname;
            streetnum = stnum;
            floornum = flnum;
            flatnum = num;
            city = c;

        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Streetname
        {
            get { return streetname; }
            set { streetname = value; }
        }

        public double Streetnum
        {
            get { return streetnum; }
            set
            {
                if (streetnum > 0)
                    streetnum = value;
            }
        }

        public int Floornum
        {
            get { return floornum; }
            set
            {
                if (value > 0)
                    floornum = value;
            }

        }

        public int Flatnum
        {
            get { return flatnum; }
            set
            {
                if (value > 0)
                {
                    flatnum = value;
                }
            }
        }

    }

    class Customer : Person
    {
        private int id;
        public Address A = new Address();
        internal string[] comp = new string[] { "transisitors", "Capacitors", "resistors", "diodes", "7805", "7809" };



        public Customer(string n, int a, int i) : base(n, a)
        {
            id = i;
        }
        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }

        }

        public void search(string x)
        {
            foreach (string m in comp)
            {
                if (x == m)
                    Console.WriteLine("compnent chosen {0}", m);
            }
        }
    }

     
}