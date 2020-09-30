using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_4
{
    class Common : ApplicationLicense
    {
        public Common() { }
        public Common(int age, double weight, double height, string gender, int activity) : base(age, weight, height, gender, activity)
        {

        }
        public override void WarmUp()
        {
            Console.WriteLine("Функционал пробного периода версии");
            base.WarmUp();
        }
        public override void BMI()
        {
            Console.WriteLine("\nФункционал бесплатной версии");
            base.BMI();
        }
        public override void Calories()
            {
                Console.WriteLine("\nФункционал бесплатной версии");
                double calories = 0;
                if ((this.Gender == "male") || (this.Gender == "Male"))
                {
                    calories = ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) + 5);

                    Console.WriteLine($"Рекомендуемое количество калорий в день, не учитывая активность: {calories}");
                }
                else if ((this.Gender == "female") || (this.Gender == "Female"))
                {
                    calories = ((10 * this.Weight) + (6.25 * this.Height) - (5 * this.Age) - 161);

                    Console.WriteLine($"Рекомендуемое количество калорий в день, не учитывая активность: {calories}");
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
