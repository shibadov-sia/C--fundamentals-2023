using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static long CDF(int n)
        {
            if (n <= 0)
                return 1;

            long result = 1;
            for (int i = n; i >= 1; i -= 2)
            {
                result *= i;
            }

            return result;
        }
        static void Main() 
        {
            Console.Write("Введите число от 1 до 68 ");
            int number = int.Parse(Console.ReadLine());

            long doubleFactorial = CDF(number);

            Console.WriteLine($"{number}!! = {doubleFactorial}");

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
