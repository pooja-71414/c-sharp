using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class student
    {
        int id;
        string name;
        public int n
        {
            get
            {
                return id;
            }
            set
            { id = value; }
        }
        public string nm
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.n = 1;
            s.nm = "raj";
            Console.WriteLine("id="+s.n);
            Console.WriteLine("name="+s.nm);
            Console.Read();
        }
    }
}
