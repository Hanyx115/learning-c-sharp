using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class CelestialBody
    {
        private string name;
        private string type;

        private string Children;
        private string[] children = new string[5];

        public CelestialBody(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public string names { get; }

        public string types { get; }

        private string children1;

        public string GetChildren()
        {
            return children1;
        }

        public void SetChildren(string value)
        {
            children1 = value;
        }

        public static void AddChild(string child1)
        { 


            if (children.Length == 5)
            {
                Console.WriteLine("full");

            }
            else
            {
                hildren += child1;
            }

        }
        public string  Getchildren(string Children1)
        {
            return string.Join(", ", children);

        }







    }
}
