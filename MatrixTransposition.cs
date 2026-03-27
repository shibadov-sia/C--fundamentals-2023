using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3; // Количество строк массива
            int columns = 4; // Количество столбцов массива

            int[,] array = new int[rows, columns]; // Создание массива(таблицы???)

            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 101); //случайное числа от 1 до 100
                }
            }

            // Вывод массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
   
            // меняет положение строк и столбца

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();



/*
комментарий спустя 3 года: а я ведь даже не знал что такое матрица как это вообще заработало
все файлы в этой линии были НОРМАЛЬНО названы весной 2026 а то они все назывались Program.cs
маленький я считал названия лишней тратой времени (((
*/



        }
    }
}
