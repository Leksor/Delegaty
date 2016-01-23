using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class B
    {
        private int ileRazy;

        public B()
        {
            ileRazy = 0;
        }

        public void Listener(A a)
        {
            a.ExampleEvent += new A.Z(MB);      
        }

        private void MB(bool result)
        {
            Console.WriteLine("Wartość przekazana przez delegat: " + result);

            if(result)
            {
                ++ileRazy;
                Console.WriteLine("Wartość pola ileRazy: " + ileRazy);
            }          
        }
    }
}
