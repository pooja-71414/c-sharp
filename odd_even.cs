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
            
            //program for find odd/even number---
            Console.WriteLine("");
    		    if((a%2)==0)
    		    {
    			    Console.WriteLine("value of a is even");	
    		    }
    		    else
    		    {
    			    Console.WriteLine("value of a is odd");
    		    }
    		    if((b%2)==0)
    		    {
    			   Console.WriteLine("value of b is even");
    		    }
    		    else
    		    {
    			    Console.WriteLine("value of b is odd");
    		    }
    		    if((c%2)==0)
    		    {
    			    Console.WriteLine("value of c is even");	
    		    }
    		    else
    		    {
                    Console.WriteLine("value of c is odd");
    		    }            
            Console.Read();
            
        }
    }
}

