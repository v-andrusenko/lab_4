using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_4_3
{
    class Pirate
    {
        public string Name { get; set; }
        public string ShipName { get; set; }
        public string Rank { get; set; }
        public Pirate() { }
        public Pirate(string name, string shipName, string Rank)
        {
            this.Name = name;
            this.ShipName = shipName;
            this.Rank = Rank;
        }
        
        public virtual void Information()
        {
            Console.WriteLine($"Имя: {this.Name}");
            Console.WriteLine($"Название корабля: {this.ShipName}");
            Console.WriteLine($"Должность: {this.Rank}");
            Debug.WriteLine($"Класс Pirate: имя {this.Name}, корабль '{this.ShipName}', должность '{this.Rank}'\n");
        }
    }
}
