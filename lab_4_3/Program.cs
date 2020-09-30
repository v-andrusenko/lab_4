using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate JohnSilver = new Pirate("Джон Сильвер", "Морж", "Квартирмейстер");
            JohnSilver.Information();

            Captain CaptainFlint = new Captain("Джеймс Флинт", "Морж", "Капитан", 25, "Нассау");
            CaptainFlint.Information();

            Сarpenter JackSmith = new Сarpenter("Джек Смит", "Морж", "Плотник", "Бригантина");
            JackSmith.Information();

            Gunner WillTurner = new Gunner("Уилл Тёрнер", "Морж", "Канонир", 32, "Бомбарда");
            WillTurner.Information();

            Console.ReadLine();

        }
    }
}
