using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //when we can use collections in c#(sharp)
namespace arraylist
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();
            Console.WriteLine("arr.Add(\"aksha\");\r\n");
            arr.Add("aksha");
            Console.WriteLine("arr.Add(\"braz\");\r\n");
            arr.Add("braz");
            Console.WriteLine("arr.Add(\"cehanaz\");\r\n");
            arr.Add("cehanaz");
            Console.WriteLine("arr.Add(\"dynamite\");\r\n");
            arr.Add("dynamite");
            Console.WriteLine("arr.Add(420);\r\n");
            arr.Add(420);
            Console.WriteLine("arr.Add(7.47);\r\n");
            arr.Add(7.47);
            Console.WriteLine("arr.Insert(3, \"denim\");\r\n");
            arr.Insert(3, "denim");
            Console.WriteLine("arr.Remove(\"dynamite\");\r\n");
            arr.Remove("dynamite");
            Console.WriteLine("arr.RemoveAt(4);\r\n");
            arr.RemoveAt(4);


            Console.WriteLine("bool b = arr.Contains(\"hiii\");\r");
            bool b = arr.Contains("hiii");
            Console.WriteLine(b + "\n");


            //arr.Clear();  //clear all elements in arraylist's

            Console.WriteLine("total elements in arraylist is = {0}", arr.Count);

            foreach (object i in arr)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
