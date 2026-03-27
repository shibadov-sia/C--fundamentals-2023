using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void show(string txt)
        {
            Console.WriteLine(txt);
        }
            static int factorial(int n)
            {
            int s = 1;
            for (int k = 1; k <= n; k++) { 
            s*= k;
            }
            return s;
        }
        static double power(double x, int n) {
        double s = 1;
            for (int k = 1; k <= n; k++)
            {
                s*= x;
            }
            return s;

        }
        static void Main() {
            show("начинаем вычисления");
            Console.WriteLine("напишите любое число от 1 до 31");
            String m = Console.ReadLine();
            Console.WriteLine(Int32.Parse(m));
            double z = 3, num;
            show(m + "!=" + factorial(Int32.Parse(m)));
            num = power(z, Int32.Parse(m));
            show(z + " в степени" + m + ": " + num);
        
        
         Console.ReadKey();
        }
        
/*
27.03.2026
это самый странный код который я только писал
по какойто неведомой причине я решил что у факториала должна быть своя функция      
*/     
        
        
        
        
        
        
        
        
        
        
        
    }
}
