using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_4_1
{
    class Cats : Animals
    {
        public string Breed { get; set; }
        public Cats() : base() { }
        public Cats (string name, int age, string gender, string type, string breed) : base(name, age, gender, type)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = type;
            this.Breed = breed;

        }
        public void Information()
        {
            Debug.WriteLine($"Имя: {this.Name}");
            Debug.WriteLine($"Возраст: {this.Age}");
            Debug.WriteLine($"Пол: {this.Gender}");
            Debug.WriteLine($"Семейство: {this.Type}");
            Debug.WriteLine($"Порода: {this.Breed}");
            Debug.WriteLine($"Класс: {GetType()}\n");

        }

    }
}
