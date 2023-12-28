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
            int i;
            string s;
            double d;
            char c;
            Console.Write("enter value of char c = ");
            c = Convert.ToChar(Console.ReadLine());
            Console.Write("enter value of int i = ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value of string s = ");
            s = Console.ReadLine();
            Console.Write("enter value of double d = ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("value of char c = {0}", c);
            Console.WriteLine("value of int i = {0}",i);
            Console.WriteLine("value of string s = {0}", s);
            Console.WriteLine("value of double d = {0}", d);
            Console.Read();

        }
    }
}
