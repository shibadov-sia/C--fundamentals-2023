using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
    
        static void show(string txt)
        {
            Console.WriteLine("Текст: "+txt);

        }
       
    
        static void show(int num) {
            Console.WriteLine("Целое число: "+num);
        
        }
    
        static void show(double num)
        {
            Console.WriteLine("Действительное число: "+num);
        }
    
        static void show(char s)
        {
            Console.WriteLine("Символ: "+s);
        }
        static void show(int num, char s)
        {
            Console.WriteLine("Аргyменты {0} и {1}",num,s);
        }
        static void Main()
        {
            int num = 5;
            double z = 12.5;
            char symb = 'W';
            show(symb);
            show("Знакомимся с перегрузкой методов");
            show(num);
            show(z);
            show(num,'Q');
        }













    }
}
