using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_2
{
    class B2 : B
    {
        public B2(string country, string city, DateTime cityTime) : base(country, city, cityTime) { }
        public override void ShortDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToLongDateString()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}
