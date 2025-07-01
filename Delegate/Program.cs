using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber s1 = new Subscriber(10);
            Subscriber s2 = new Subscriber(20);
            Subscriber s3 = new Subscriber(30);
            Subscriber s4 = new Subscriber(40);
            
            Observer o = new Observer();
            o.AddSub(s1);
            o.AddSub(s2);
            o.AddSub(s3);
            o.AddSub(s4);

            foreach (Action a in o.funcs) a.Invoke();

            List<Subscriber> sList = new List<Subscriber>();
            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);
            sList.Add(s4);
            foreach (Subscriber s in sList) Console.WriteLine(s.a);
        }
    }

    class Observer
    {
        public List<Action> funcs = new List<Action>();
        public void AddSub(Subscriber s)
        {
            funcs.Add(s.plusA);
        }
    }

    class Subscriber
    {
        public int a;
        public Action plusA;
        public Subscriber(int a)
        {
            this.a = a;
            plusA = Plus;
        }
        public void Plus()
        {
            a += 10;
        }
    }
}
