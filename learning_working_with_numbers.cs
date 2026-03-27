using System;
using Microsoft.VisualBasic;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числа:");

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 5 == 2)
                {
                    Console.WriteLine(number+" Это число прошло проверку ");
                }
                else
                {
                    Console.WriteLine(number+" Это число не прошло проверку ");
                }
            }
                
                
                Console.WriteLine("нажмите Enter чтобы продолжить");
                Console.ReadLine();





































            
        }
    }
}
