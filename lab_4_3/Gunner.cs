using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_3
{
    class Gunner : Pirate
    {
        public int Cannons { get; set; }
        public string CannonType { get; set; }
        public Gunner() { }
        public Gunner(string Name, string ShipName, string Rank, int cannons, string cannon_type) : base(Name, ShipName, Rank)
        {
            this.Cannons = cannons;
            this.CannonType = cannon_type;
        }
        public override void Information()
        {
            Console.WriteLine($"Имя {this.Name}\nКорабль '{this.ShipName}'\nДолжность '{this.Rank}'\n" +
                $"Количество пушек в обслуживании: {this.Cannons}\nТип пушек: {this.CannonType}\n");
            Debug.WriteLine($"Класс Gunner: имя {this.Name}\nкорабль '{this.ShipName}'\nдолжность '{this.Rank}'\n" +
                $"Количество пушек в обслуживании: {this.Cannons}\nТип пушек: {this.CannonType}\n");
        }
    }
}
