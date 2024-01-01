using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace same_class
{
    namespace n
    {
        class A
        {
            public A()
            {
                Console.WriteLine("this is namespace n class A");
            }
        }
    }
    namespace m
    {
        class A 
        {
            public A()
            {
                Console.WriteLine("this is namespace m class A");
            }
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            n.A a = new n.A();
            m.A m = new m.A();
            Console.Read();
        }
    }
}
