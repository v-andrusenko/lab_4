using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals("Дориан", 3, "мужской", "кошачьи");
            animal.Information();

            Cats cat = new Cats("Тихон", 6, "мужской", "кошачьи", "сибирский");
            cat.Information();

            Animals animal1 = (Animals)cat;
            animal1.Information();

            Cats cat1 = (Cats)animal1;
            cat1.Information();
            
            Console.ReadLine();
        }
    }
}
