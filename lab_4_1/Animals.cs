using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_4_1
{
    class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }

        public Animals() { }
        public Animals(string name, int age, string gender, string type)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = type;
        }

        public void Information()
        {
            Debug.WriteLine($"Имя ({this.Name.GetType()}): {this.Name}");
            Debug.WriteLine($"Возраст ({this.Age.GetType()}): {this.Age}");
            Debug.WriteLine($"Пол ({this.Gender.GetType()}): {this.Gender}");
            Debug.WriteLine($"Семейство ({this.Type.GetType()}): {this.Type}");
            Debug.WriteLine($"Класс: {GetType()}\n");
        }
    }
}
