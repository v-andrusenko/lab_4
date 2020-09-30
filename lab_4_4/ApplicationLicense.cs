using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_4
{
    class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Пробный период");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void AllowCommon()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Бесплатная версия");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void AllowPro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Платная версия");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public virtual void WarmUp()
        {
            Console.WriteLine("\t\t\tРазминка");
            Console.WriteLine(
                "1. Круговые вращения головой (по 5 в разные стороны)\n" +
                "2. Круги руками (по 5 кругов в разные стороны)\n" +
                "3. Наклоны с руками за головой (10 раз)\n" +
                "4. Махи руками (по 10 раз в разные стороны)\n" +
                "5. Глубокий наклон в сторону(по 5 в каждую сторону)\n" +
                "6. Приседания (15 раз)\n" +
                "7. Отжимания (20 раз)\n");
        }

        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Gender { get; set; }
        public int Activity { get; set; }
        public ApplicationLicense() { }
        public ApplicationLicense(int age, double weight, double height, string gender, int activity)
        {
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.Gender = gender;
            this.Activity = activity;
        }
        public virtual void BMI()
        {
            if (this.Age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Данная формула может показывать ошибочный индекс для детей");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            double result = (this.Weight / (this.Height*this.Height))*10000;
            Console.Write("Ваш индекс массы тела: ");
            if (result <= 16)
            {
                Console.WriteLine($"{result} - выраженный дефицит массы тела");
            }
            else if ((result > 16) && (result <= 18.5))
            {
                Console.WriteLine($"{result} - дефицит массы тела");
            }
            else if ((result > 18.5) && (result <= 25))
            {
                Console.WriteLine($"{result} - нормальная масса тела");
            }
            else if ((result > 25) && (result <= 30))
            {
                Console.WriteLine($"{result} - избыточная масса тела");
            }
            else if ((result > 30) && (result <= 35))
            {
                Console.WriteLine($"{result} - ожирение");
            }
            else if ((result > 35) && (result <= 40))
            {
                Console.WriteLine($"{result} - резкое ожирение");
            }
            else if (result > 40)
            {
                Console.WriteLine($"{result} - очень резкое ожирение");
            }
        }
        public virtual void Calories()
        {
            double calories = 0;
            if ((this.Gender == "male") || (this.Gender == "Male"))
            {
                switch (this.Activity)
                {
                    case 1:
                        calories = 1.2 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);
                        break;
                    case 2:
                        calories = 1.375 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);
                        break;
                    case 3:
                        calories = 1.55 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);
                        break;
                    case 4:
                        calories = 1.725 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);
                        break;
                    case 5:
                        calories = 1.9 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);
                        break;
                    default:
                        calories = ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);
                        break;
                }
                Console.WriteLine($"Рекомендуемое количество калорий в день: {calories}");
            }
            else if ((this.Gender == "female") || (this.Gender == "Female"))
            {
                switch (this.Activity)
                {
                    case 1:
                        calories = 1.2 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);
                        break;
                    case 2:
                        calories = 1.2 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);
                        break;
                    case 3:
                        calories = 1.2 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);
                        break;
                    case 4:
                        calories = 1.2 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);
                        break;
                    case 5:
                        calories = 1.2 * ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);
                        break;
                    default:
                        calories = ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);
                        break;
                }
                Console.WriteLine($"Рекомендуемое количество калорий в день: {calories}");
            }
            else
            {
                Console.WriteLine("К сожалению, программа не считает рекомендуемые калории для введённого гендера. Вот формулы:\n" +
             "Для женщин: коэф.активности * ((10 × вес в килограммах) + (6,25 × рост в сантиметрах) − (5 × возраст в годах) − 161)\n" +
             "Для мужчин: коэф.активности * ((10 × вес в килограммах) + (6, 25 × рост в сантиметрах) − (5 × возраст в годах) +5)\n");
            }
        }
    }
}

