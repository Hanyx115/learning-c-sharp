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


        public Person() { }
        public Person(string n, int a)
        {
            name = n;
            age = a;

        }

        public virtual void signup(string u, int a)
        {

        }
        public virtual void login(string u, int a)
        {

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
    internal class ASMComponent
    {
        private int id;
        private string name;
        private double price;
        private int quantity;

        public ASMComponent(int id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }

    class Customer : Person
    {
        private int id;
        public Address A = new Address();
        internal string[] comp = new string[] { "transisitors", "Capacitors", "resistors", "diodes", "7805", "7809" };

        public Customer()
        { }

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
    class Account : Customer
    {
        private string username;
        private int password;

        public Account(string n, int a, int i, string username, int password) : base(n, a, i)
        {
            this.username = username;
            this.password = password;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Password
        {
            get { return password; }
            set { password = value; }
        }

        public override void signup(string u, int pass)
        {
            username = u;
            password = pass;

        }

        public override void login(string u, int pass)
        {
            if (u == username && pass == password)
            {
                Console.WriteLine("you are login in");

            }


        }


    }
    class employee : Person
    {
        private int empid;
        private string dep;

        public employee(int e, string d, string n, int a) : base(n, a)
        {
            empid = e;
        }

        public void Assistcustomer()
        {
            Console.WriteLine("Hello Customer, how may i help you?");

        }
        public override void signup(string u, int pass)
        {
            dep = u;
            empid = pass;

        }

        public override void login(string u, int pass)
        {
            if (u == dep && pass == empid)
            {
                Console.WriteLine("you are login in");

            }


        }



    }

    class Order : ASMComponent
    {
        private int orderid;
        private string cusname;
        private string ordercomp;

        public Order(int id, string name, double price, int quantity, int o, string c, string oc) : base(id, name, price, quantity)
        {
            orderid = o;
            cusname = c;
            ordercomp = oc;

        }
        public int OrderID
        {
            get { return orderid; }
            set { orderid = value; }

        }
        public string CustomerName
        {
            get { return cusname; }
            set { cusname = value; }
        }
        public string OrderCompenent
        {
            get { return ordercomp; }
            set { ordercomp = value; }
        }

        public override string ToString()
        {
            return string.Format($"your customer name is: {cusname}\nyour components id is: {orderid}\nyour component is: {ordercomp}\n the quanitity is " +
                $": {Quantity}\n your price in each compenenot: {Price} ");


        }



    }
}