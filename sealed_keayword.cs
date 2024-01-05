using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_keyword
{
    sealed class A
    {
        public A()
        {
            Console.WriteLine("sealed class A default constructor..");
        }
    }
    //class MyClass2 : MyClass //can occure error because sealed class can't inherit..
    class B
    { 
        public B()
        { 
            Console.WriteLine("B class default constructor.."); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();  
            B b = new B();
            Console.Read();     
        }
    }
}
