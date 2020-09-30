using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_3
{
    class Captain : Pirate
    {
        public int Experience { get; set; }
        public string MainPort { get; set; }
        public Captain() { }
        public Captain(string Name, string ShipName, string Rank, int Experience, string MainPort) : base(Name, ShipName, Rank)
        {
            this.Experience = Experience;
            this.MainPort = MainPort;
        }
        public override void Information()
        {
            Console.WriteLine($"\n{this.Rank} корабля '{this.ShipName}' {this.Name}");
            Console.WriteLine($"Стаж: {this.Experience}\nПорт: {this.MainPort}");
            Debug.WriteLine($"Класс Captain: имя {this.Name}\nКорабль '{this.ShipName}'\nДолжность '{this.Rank}'\n" +
                $"Стаж: {this.Experience}\nПорт: {this.MainPort}\n");
        }

    }
}
