using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_with_multiple_constructors
{
    class inheritance
    {
        public inheritance() 
        {
            Console.WriteLine("this is default base class constructor..");
        }
        public inheritance(int x) 
        {
            Console.WriteLine("one args base class constructor x = {0}", x);
        }
    }
    class extend_class : inheritance
    {
        public extend_class()
        {
            Console.WriteLine("this is default derived class constructor..");
        }
        public extend_class(int y):base(200) 
        {
            Console.WriteLine("one args derived class constructor y = {0}", y);
        }
    }
    class sub_class : extend_class
    {
        public sub_class()
        {
            Console.WriteLine("this is default sub class constructor..");
        }
        public sub_class(int z):base(500)
        {
            Console.WriteLine("one args sub class constructor z = {0}", z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sub_class s = new sub_class();
            sub_class s1 = new sub_class(700);
            Console.Read();
        }
    }
}
