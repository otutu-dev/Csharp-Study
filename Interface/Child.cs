using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Child : Parent
    {
        public override void Print()
        {
            Console.WriteLine("Child Virtual Print");
        }

        public override void AbstractPrint()
        {
            Console.WriteLine("Child Abstract Print");
        }
    }
}
