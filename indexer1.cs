using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class A
        {
            int size = 10;
            int i;
            string[] m = new string[10];
            /*public A()
            {
                for (i = 0; i < size; i++)
                {
                    m[i] = "india";
                    //Console.WriteLine(m[i]);
                }
            }*/
            public string this[int i]
            {
                get { return m[i]; }
                set { m[i] = value; }
            }
        }
        static void Main(string[] args)
        {
            //use of indexer---
            A s = new A();
            s[2] = "korea";
            s[4] = "hindustan";
            s[7] = "gujarat";
            s[9] = "bharat";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(s[i]);
            }

        }
    }
}
