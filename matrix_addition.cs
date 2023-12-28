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
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];
            Console.WriteLine("-------enter matrix a---------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i,j]=Convert.ToInt32(Console.ReadLine());                   
                }               
            }
            Console.WriteLine("-------enter matrix b---------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("b[{0},{1}]=", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("matrix a-------matrix b");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}  ", a[i, j]);

                }
                 Console.Write("\t");
                 for (int j = 0; j < 3; j++)
                 {
                     Console.Write("{0}  ", b[i, j]);

                 }
                
                Console.WriteLine("");
            }
            Console.WriteLine("-----addition of matrix a and b-----");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i,j]=a[i,j]+b[i,j];
                    Console.Write("{0}  ", c[i, j]);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
