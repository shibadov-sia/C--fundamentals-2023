using System;

using System.Linq;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здраствуй случайный чел которыый решил посмотреть сюда спусть миллионы лет ");
            Console.WriteLine("Это программа для ввода случайных символов из английского алфавита количество которых выбераешь ты ");
            Console.WriteLine("Давай ты делай то что тебе говорят я итак много уже сказал ");
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            char[] chara = new char[size];
            Random random = new Random();

            // Заполнение массива случайными символами
            for (int i = 0; i < size; i++)
            {
                chara[i] = (char)random.Next(65, 91); // Генерация символов от 'A' до 'Z'
            }

            // Вывод элементов массива
            Console.WriteLine("Элементы массива:");
            foreach (char character in chara)
            {
                Console.Write(character + " ");
            }

            Console.ReadLine();
        }
    }
}
