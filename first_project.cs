using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a;
            String b;
            String c;
            String d;
            String e;
            String f;
            int g;
            g = 0;
            Console.WriteLine("Здрваствуйте это опрос на уровень интеллекта");
            Console.WriteLine("вам нужно ответить на вопросы затем ваш уровень интеллекта сложат и скажут вы тупые или нет");
            Console.WriteLine("Почему небо голубое?");
            a = Console.ReadLine();
            Console.WriteLine("Назовите химическую формулу воды?(писать на английском с большими буквами)");
            b = Console.ReadLine();
            Console.WriteLine("Сколько нулей в гугл плекс?(писать цифрами)");
            c = Console.ReadLine();
            Console.WriteLine("Правильно говорить нет или нету?");
            d = Console.ReadLine();
            Console.WriteLine("Шахин Умный или нет(писать да или нет)");
            e = Console.ReadLine();
            Console.WriteLine("Финальный вопрос Назовите первые 20 цифор числа Пи?(писать цифрами)");  
            f = Console.ReadLine();
            if (a == "Отражение солнца с океаном"){
                g = g + 20;
            }
            else g = g - 0;
            if (b == "H2O")
            {
                g = g + 20;
            }
            else g = g - 0;
            if (c == "100")
            {
                g = g + 20;
            }
            else g = g - 0;
            if (d == "нет")
            {
                g = g + 20;
            }
            else g = g - 0;
            if (e == "да")
            {
                g = g + 20;
            }
            else g = g - 0;
            if (f == "3,1415926535897932384")
            {
                g = g + 200;
            }
            else g = g - 0;
           
            if (g<=0)
            {
                Console.WriteLine("надо было писять да");
            };
            
            if (g == 40) 
            {
                Console.WriteLine("у меня рыбка была умнее");
            };

            if (g == 60)
            {
                Console.WriteLine("ок");
            };
            
            if (g == 80)
            {
                Console.WriteLine("выше среднего");
            };
            
            if (g >= 110)
            {
                Console.WriteLine("Ты умнее Энштена");
            };
            
            
            Console.WriteLine();
            Console.WriteLine("оцени тест по 10 балльно шкале");
            Console.ReadLine();
            Console.WriteLine("Спасибо за отзыв");
            Console.WriteLine("нажмите на Enter что бы закрыть");
            Console.ReadLine();






        }
    }
}
