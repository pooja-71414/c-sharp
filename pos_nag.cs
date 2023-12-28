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
            int a, b, c;
            Console.Write("enter value of a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value of b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value of c = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("value of a = {0}", a);
            Console.WriteLine("value of b = {0}", b);
            Console.WriteLine("value of c = {0}", c);
            Console.WriteLine("");

            //program for find positive/nagative number---
            Console.WriteLine("");
            if (a > 0)
            {
                Console.WriteLine("value of a is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("value of a is nagative");
            }
            else
            {
                Console.WriteLine("value of a is zero");
            }
            if (b > 0)
            {
                Console.WriteLine("value of b is positive");
            }
            else if (b < 0)
            {
                Console.WriteLine("value of b is nagative");
            }
            else
            {
                Console.WriteLine("value of b is zero");
            }
            if (c > 0)
            {
                Console.WriteLine("value of c is positive");
            }
            else if (c < 0)
            {
                Console.WriteLine("value of c is nagative");
            }
            else
            {
                Console.WriteLine("value of c is zero");
            }  
            Console.Read();           
        }
    }
}

