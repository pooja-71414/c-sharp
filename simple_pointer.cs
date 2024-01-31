using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_pointer
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int a = 70;
            int* b = &a;

            Console.WriteLine("value of a = {0}", a);
            Console.WriteLine("address of a = {0}", (int)&a);
            Console.WriteLine("value of a = {0}", *b);
            Console.Read();
        }
    }
}
