using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_4
{
    class Program
    {
        static int Age()
        {
            int age;
            Console.Write("Укажите Ваш возраст: ");
            do
            {
                age = int.Parse(Console.ReadLine());
                if (age <= 0) { Console.Write("Укажите реальный возраст: "); }
            }
            while (age <= 0);
            return age;
        }
        static double Weight()
        {
            double weight;
            Console.Write("Укажите Ваш вес (используйте ',' вместо '.'): ");
            do
            {
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0) { Console.Write("Укажите реальный вес: "); }
            }
            while (weight <= 0);
            return weight;
        }
        static double Height()
        {
            double height;
            Console.Write("Укажите Ваш рост (используйте ',' вместо '.'): ");
            do
            {
                height = double.Parse(Console.ReadLine());
                if (height <= 0) { Console.Write("Укажите реальный рост: "); }
            }
            while (height <= 0);
            return height;
        }
        static string Gender()
        {
            string gender;
            Console.Write("Укажите Ваш пол (male, female): ");
            gender = Console.ReadLine();
            return gender;
        }
        static int Activity()
        {
            int activity;
            Console.WriteLine("\nКод активности:\n1 - если у вас нет физических нагрузок и сидячая работа\n" +
                          "2 - если вы совершаете небольшие пробежки или делаете легкую гимнастику 1–3 раза в неделю\n" +
                          "3 - если вы занимаетесь спортом со средними нагрузками 3–5 раз в неделю\n" +
                          "4 - если вы полноценно тренируетесь 6–7 раз в неделю\n" +
                          "5 - если ваша работа связана с физическим трудом, вы тренируетесь 2 раза в день и включаете в программу тренировок силовые упражнения\n");
            Console.Write("Укажите Вашу активность: ");
            activity = int.Parse(Console.ReadLine());
            return activity;
        }

        static void Main(string[] args)
        {
            Console.Write("Активируйте ключ приложения: ");
            string key = Console.ReadLine();
            ApplicationLicense Client = new ApplicationLicense();
            int age = 0, activity = 0;
            double weight = 0, height = 0;
            string gender;
            switch (key)
            {
                case "pro":
                    Client.AllowPro();
                    
                    break;
                case "trial":
                    Client.AllowTrial();

                    break;
                case "":
                    Client.AllowCommon();

                    break;
                default: Console.WriteLine("Вам отказано в доступе к приложению");
                    Console.ReadLine();  
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Отлично! Приступим к вводу Ваших параметров.");
            age = Age();
            weight = Weight();
            height = Height();
            gender = Gender();
            activity = Activity();
            Console.WriteLine();
            if (key == "pro") 
            { 
                Pro Valera = new Pro(age, weight, height, gender, activity);
                Valera.WarmUp();
                Valera.BMI();
                Valera.Calories();
            }
            else if (key == "trial") 
            { 
                Trial Valera = new Trial(age, weight, height, gender, activity);
                Valera.WarmUp();
                Valera.BMI(); 
                Valera.Calories(); 
            }
            else 
            { 
                Common Valera = new Common(age, weight, height, gender, activity);
                Valera.WarmUp();
                Valera.BMI();
                Valera.Calories();
            }
            Console.WriteLine();
        }
    }
}
