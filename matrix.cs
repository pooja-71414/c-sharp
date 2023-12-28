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
            //enter matrix----------
            int[,] a = new int[3, 3];
            Console.WriteLine("-------enter matrix a---------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i,j]=Convert.ToInt32(Console.ReadLine());                   
                }               
            }
            //print matrix-----------
            Console.WriteLine("------- matrix a---------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}  ", a[i,j]);
                    
                }
                Console.WriteLine("");
            }


            Console.Read();

        }
    }
}
