using System;


namespace ConsoleApp17
{
    internal class Program
    {
        static int factorial(int n)
        {
        
            if (n == 1) return 1;
            else return n*factorial(n-1);
        
        }
        static int fibs(int n)
        {

            if (n == 1 || n == 2) return 1;
            else return fibs(n - 1) + fibs(n - 2);
        
        }
        static int sum(int n)
        {
            if (n == 0) return 0;
            else
                return n + sum(n-1);
        }
        static void show(int [] a,int k)
        {
            
            Console.Write(a[k]+" ");
            if (k == a.Length-1)
            {
                Console.WriteLine();
            }
            else
            {
                show(a, k + 1);
            }

        }
        static void show(int[] a)
        {

            show(a,0);
        
        }

        static void Main()
        {
        
            Console.WriteLine("Факториал числа");
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i+"!="+factorial(i));
            }
            
            Console.WriteLine("Числа Фибоначчи");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(fibs(i)+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма чисел от 1 до 100");
            Console.WriteLine(sum(100));
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            Console.WriteLine("Числовой массив");
            show(A);
            Console.WriteLine("Элементы, начиная  стретьего:");
            show(A,2);

        }


































    }
}
