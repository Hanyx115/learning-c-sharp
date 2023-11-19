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

        public static void AddChild(string children)
        { string child1 = Console.ReadLine();


            if (children.Length == 5)
            {
                Console.WriteLine("full");

            }
            else
            {
                children += child1;
            }

        }
        public string  Getchildren(string Children1)
        {
            int i = 0;
            for (i = 0; i < children.Length; i++)
            {
                if (children[i] ==null )
                {
                    children[i] = Children1;
                }
                
            }

            return Children;
        }







    }
}
