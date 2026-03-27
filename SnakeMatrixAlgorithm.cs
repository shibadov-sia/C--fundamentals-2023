using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 4; // Количество строк массива
            int columns = 5; // Количество столбцов массива

            int[,] array = new int[rows, columns]; // Создание двумерного числового массива(оказывается он так называется)

            int number = 1; // Начальное значение для заполнения массива

            // Заполнение массива "улиткой гэри"
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = number;
                        number++;
                    }
                }
                else
                {
                    for (int j = columns - 1; j >= 0; j--)
                    {
                        array[i, j] = number;
                        number++;
                    }
                }
            }

            // Вывод массива на консоль
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

/*
27.03.2026
я даже сейчас не могу сделать змейку как я тогда ее сделал
*/









            Console.ReadKey();
        }
    }
}
