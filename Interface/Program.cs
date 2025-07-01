using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            Child c = new Child();

            p.Print();
            c.Print();

            p.AbstractPrint();
            c.AbstractPrint();

            IPrintable ipa = p;

            ipa.Print();
        }
    }
}
