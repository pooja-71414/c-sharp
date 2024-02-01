using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace delegates
{
    internal class Program
    {
        public delegate void delegate_obj(int x, int y);
        static void add(int a, int b)
        {
            Console.WriteLine("addition of {0} and {1} = {2}", a, b, a + b);
        }
        static void sub(int a, int b)
        {
            Console.WriteLine("substraction of {0} and {1} = {2}", a, b, a - b);
        }
        static void mul(int a, int b)
        {
            Console.WriteLine("multiplication of {0} and {1} = {2}", a, b, a * b);
        }
        static void div(int a, int b)
        {
            Console.WriteLine("division of {0} and {1} = {2}", a, b, a / b);
        }
        unsafe static void Main(string[] args)
        {
            int p, q;
            //single dlegates
            Console.WriteLine("******** single delegates program *******");
            delegate_obj d = new delegate_obj(add);
            d(4, 56);

            //multicast delegates
            Console.WriteLine("******** enter values for operations *******");

            Console.Write("enter first number = ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number = ");
            q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******** multi-cast delegates program *******");

            delegate_obj d1 = new delegate_obj(add);
            d1 += new delegate_obj(sub);
            d1 += new delegate_obj(mul);
            d1 += new delegate_obj(div);
            d1(p, q);
            Console.Read();
        }
}
