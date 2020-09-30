using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_2
{
    class A
    {
        B b1;
        B b2;
        B b3;
        public A() { }
        public A (B b1, B b2, B b3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
        public A (B b1, B b2) : this(b1, b2, null) { }
        public void Time()
        {
            if (b3 == null)
            {
                Console.WriteLine($"{b1.country}, {b1.city}: {b1.cityTime}");
                Console.WriteLine($"{b2.country}, {b2.city}: {b2.cityTime}\n");
            }
            else
            {
                Console.WriteLine($"{b1.country}, {b1.city}: {b1.cityTime}");
                Console.WriteLine($"{b2.country}, {b2.city}: {b2.cityTime}");
                Console.WriteLine($"{b3.country}, {b3.city}: {b3.cityTime}\n");

            }
        }

    }
}
