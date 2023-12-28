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
            //enter any number and print this number of table
            int a;
            Console.Write("enter number for table = ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",a,i,a*i);
            }
            Console.Read();
            
        }
    }
}

