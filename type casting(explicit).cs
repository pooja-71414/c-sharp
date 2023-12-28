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
            int i;
            double d = 25.45,d1 = 35.68;       
                        //i = f;    //error
            i = Convert.ToInt32(d);
            Console.WriteLine("value of double d = {0}",d);
            Console.WriteLine("double value d = 25.45  converse into int type therefore i = {0}", i);
            i = Convert.ToInt32(d1);
            Console.WriteLine("double value d1 = 35.68  converse into int type therefore i = {0}", i);
            Console.Read();
        }
    }
}
