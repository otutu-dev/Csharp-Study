using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object i = "10";
            string s = i as string;

            Console.WriteLine(s);

            Console.WriteLine(s is null);
        }
    }
}
