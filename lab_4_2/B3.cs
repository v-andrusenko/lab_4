using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_2
{
    class B3 : B
    {
        public B3(string country, string city, DateTime cityTime) : base(country, city, cityTime) { }
        public override void OnlyTime()
        {
            Console.WriteLine($"{city}: {cityTime.ToLongTimeString()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}
