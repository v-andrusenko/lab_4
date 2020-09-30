using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_4
{
    class Pro : ApplicationLicense
    {
        public Pro() { }
        public Pro(int age, double weight, double height, string gender, int activity) : base(age, weight, height, gender, activity)
        {

        }
        public override void WarmUp()
        {
            Console.WriteLine("Функционал платной версии");
            base.WarmUp();
        }
        public override void BMI()
        {
            Console.WriteLine("\nФункционал платной версии");
            base.BMI();
        }
        public override void Calories()
        {
            Console.WriteLine("\nФункционал платной версии");
            base.Calories();
        }
    }
}
