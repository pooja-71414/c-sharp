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
            try
            {
                int a, b, c;
                Console.Write("enter value of a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter value of b = ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("division of a({0}) and b({1}) = {2}", a, b, c);
            }
            catch (Exception e)
            {
                Console.WriteLine("-----------exception generate------");
                Console.Write("e.Message = ");
                Console.WriteLine(e.Message);
                Console.Write("e.StackTrace = ");
                Console.WriteLine(e.StackTrace);
                Console.Write("e.TargetSite = ");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine();
            }
            finally
            {
                Console.Write("finally complate");
            }
            Console.Read();

        }
    }
}
