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
            //program for find maximum number---
    		    if(a>b && a>c)
    		    {
    			    Console.WriteLine("value of a is maximum");	
    		    }
    		    else if(b>c)
    		    {
    			    if(b>a)
    			    {
    				    Console.WriteLine("value of b is maximum");
    			    }			
    		    }
    		    else if(a==b && b==c)
    		    {
    			    Console.WriteLine("value of a and b and c is equal");	
    		    }
    		    else
    		    {
    			    Console.WriteLine("value of c is maximum");
    		    }
    
                //program for find minimum number---
            Console.WriteLine("");
    		    if(a<b && a<c)
    		    {
    			    Console.WriteLine("value of a is minimum");	
    		    }
    		    else if(b<a && b<c)
    		    {
    			    Console.WriteLine("value of b is minimum");	
    		    }
    		    else if(c<a && c<b)
    		    {
    			    Console.WriteLine("value of c is minimum");	
    		    }
    		    else
    		    {
    			    Console.WriteLine("value of a and b and c is equal");	
    		    }
          
            Console.Read();
            
        }
    }
}

