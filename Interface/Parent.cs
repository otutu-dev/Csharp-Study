using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public abstract class Parent : IPrintable
    {
        public virtual void Print()
        {
            Console.WriteLine("Parent Virtual Print");
        }

        public abstract void AbstractPrint();
    }
}
