using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_2
{
    class B1 : B
    {
        public B1(string country, string city, DateTime cityTime) : base(country, city, cityTime) { }
        public override void LongDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToUniversalTime()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}
