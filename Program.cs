using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            b.Listener(a);
            a.Start();
        }
    }
}
