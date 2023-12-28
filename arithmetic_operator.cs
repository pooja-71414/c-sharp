using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dream
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = 13;
            b = 45;
            //arithmetic operation--
            Console.WriteLine("addition of " + a + " and " + b + " = " + (a + b));
            Console.WriteLine("substraction of " + a + " and " + b + " = " + (a - b));
            Console.WriteLine("multiplication of " + a + " and " + b + " = " + (a * b));
            Console.WriteLine("division of " + a + " and " + b + " = " + (a / b));
            Console.WriteLine("reminder of " + a + " and " + b + " = " + (a % b));
            Console.Read(); 
        }
    }
}
