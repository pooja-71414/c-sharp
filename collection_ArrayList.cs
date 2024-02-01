using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //when we can use collections in c#(sharp)
namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack s = new Stack();

            Console.WriteLine("s.Push(\"aksha\");\r\n");
            s.Push("aksha");
            Console.WriteLine("s.Push(\"braz\");\r\n");
            s.Push("braz");
            Console.WriteLine("s.Push(\"cehanaz\");\r\n");
            s.Push("cehanaz");
            Console.WriteLine("s.Push(\"dynamite\");\r\n");
            s.Push("dynamite");
            Console.WriteLine("s.Push(420);\r\n");
            s.Push(420);
            Console.WriteLine("s.Push(7.47);\r\n");
            s.Push(7.47);
            Console.WriteLine("s.pop();\r\n");
            s.Pop();
            Console.WriteLine("s.pop();\r\n");
            s.Pop();

            Console.WriteLine("bool b = s.Contains(\"hiii\");\r");
            bool b = s.Contains("hiii");
            Console.WriteLine(b + "\n");

            //s.Clear();  //clear all elements in arraylist's

            Console.WriteLine("top element of stack is = {0}\n", s.Peek());

            Console.WriteLine("total elements in stack is = {0}", s.Count);

            foreach (object i in s)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
