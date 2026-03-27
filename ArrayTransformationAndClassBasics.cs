using System;

namespace ConsoleApp20
{
    internal class Program
    {
        public int n;
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size]; 

            FillArray(array); 
            SquareArrayElements(array); 

            
            Console.WriteLine("Массив после возведения элементов в квадрат:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            
        }

        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void SquareArrayElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
        }
    }
    internal class Progras
    {
        public int n = 10;
    }


}
