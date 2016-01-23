using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegaty
{
    class A
    {
        public delegate void Z(bool result);
        public event Z ExampleEvent;
        Timer timer;
        private bool result;
         
        public A()
        {
            timer = new Timer();
            timer.Interval = 2000; // 2sec
            result = false;
        }

        public void MA(object sender, EventArgs e)
        {
            result = !result;
            ExampleEvent(result);
        }

        public void Start()
        {
            timer.Elapsed += new ElapsedEventHandler(this.MA);
            timer.Start();
            Console.ReadKey();
        }
    }
}
