using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    internal class Program
    {
        static void Main(string[] args)
        {         

            string[] s=new string[10];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = "parangat college";
            }
            s[4] = "maharshi gurukul";
            s[1] = "science cource";
            s[6] = "commerce cource";
            s[9] = "gujarati medium";
            for (int i = 0;i < s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.Read();
        }
    }
}
