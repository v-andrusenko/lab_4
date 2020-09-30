using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_4
{
    class Trial : ApplicationLicense
    {
        public Trial() { }
        public Trial(int age, double weight, double height, string gender, int activity) : base(age, weight, height, gender, activity)
        {

        }
        public override void WarmUp()
        {
            Console.WriteLine("Функционал пробного периода версии");
            base.WarmUp();
        }
        public override void BMI()
        {
            Console.WriteLine("\nФункционал пробного периода");
            base.BMI();
        }
        public override void Calories()
        {
            Console.WriteLine("\nФункционал пробного периода");
            base.Calories();
        }

    }
}
