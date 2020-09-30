using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B city1 = new B("Украина", "Киев", DateTime.Now);
            B city2 = new B("Англия", "Лондон", DateTime.UtcNow);
            B city3 = new B("США", "Нью-Йорк", DateTime.UtcNow.AddHours(-3));
            B city4 = new B("Япония", "Токио", DateTime.UtcNow.AddHours(9));
            B city5 = new B("Австралия", "Сидней", DateTime.UtcNow.AddHours(10));
            A a1 = new A(city1, city2, city3);
            a1.Time();
            A a2 = new A(city4, city5);
            a2.Time();

            Console.WriteLine("Переопределение метода LongDate:");
            city1.LongDate();
            B1 c1 = new B1(city1.country, city1.city, city1.cityTime);
            c1.LongDate();

            Console.WriteLine("\nПереопределение метода ShortDate:");
            city2.ShortDate();
            B2 c2 = new B2(city2.country, city2.city, city2.cityTime);
            c2.ShortDate();

            Console.WriteLine("\nПереопределение метода OnlyTime:");
            city3.OnlyTime();
            B3 c3 = new B3(city3.country, city3.city, city3.cityTime);
            c3.OnlyTime();
            Console.ReadLine();
        }
    }
}
