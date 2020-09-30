using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_3
{
    class Сarpenter : Pirate
    {
        public string ShipType { get; set; }
        public Сarpenter() { }
        public Сarpenter(string Name, string ShipName, string Rank, string ship_type) : base(Name, ShipName, Rank)
        {
            this.ShipType = ship_type;
        }
        public override void Information()
        {
            Console.WriteLine($"\nИмя {this.Name}\nКорабль '{this.ShipName}'\nДолжность '{this.Rank}'\n" +
                $"Тип корабля: {this.ShipType}\n");
            Debug.WriteLine($"Класс Carpenter: имя {this.Name}\nкорабль '{this.ShipName}'\nдолжность '{this.Rank}'\n" +
                $"Тип корабля: {this.ShipType}\n");
        }
    }
}
