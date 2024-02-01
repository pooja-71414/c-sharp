using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //when we can use collections in c#(sharp)
namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue Q = new Queue();

            Console.WriteLine("Q.Enqueue(\"aksha\");\r\n");
            Q.Enqueue("aksha");
            Console.WriteLine("Q.Enqueue(\"braz\");\r\n");
            Q.Enqueue("braz");
            Console.WriteLine("Q.Enqueue(\"cehanaz\");\r\n");
            Q.Enqueue("cehanaz");
            Console.WriteLine("Q.Enqueue(\"dynamite\");\r\n");
            Q.Enqueue("dynamite");
            Console.WriteLine("Q.Enqueue(420);\r\n");
            Q.Enqueue(420);
            Console.WriteLine("Q.Enqueue(7.47);\r\n");
            Q.Enqueue(7.47);
            Console.WriteLine("Q.Dequeue();\r\n");
            Q.Dequeue();
            Console.WriteLine("Q.Dequeue();\r\n");
            Q.Dequeue();


            Console.WriteLine("bool b = Q.Contains(\"hiii\");\r");
            bool b = Q.Contains("hiii");
            Console.WriteLine(b + "\n");

            //s.Clear();  //clear all elements in arraylist's

            Console.WriteLine("top element of Queue is = {0}\n", Q.Peek());

            Console.WriteLine("total elements in Queue is = {0}", Q.Count);

            foreach (object i in Q)
            {
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}
