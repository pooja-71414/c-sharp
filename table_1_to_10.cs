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
           //table for print 1 to 10 table
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, j * i);
                }
                Console.WriteLine("");
            }
            Console.Read();    

        }
    }
}
