using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_2
{
    class B
    {
        public B() { }
        public B(string country, string city, DateTime cityTime)
        {
            this.city = city;

            this.country = country;

            this.cityTime = cityTime;

        }
        public string city { get; set; }
        public DateTime cityTime { get; set; }
        public string country { get; set; }


        public virtual void OnlyTime()
        {
            Console.WriteLine($"{city}: {cityTime.ToShortTimeString()}");
        }
        public virtual void ShortDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToShortDateString()}");
        }
        public virtual void LongDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToLongDateString()}");
        }

    }
}
