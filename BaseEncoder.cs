using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static int sum(params int[] a)
        {
            
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                res += a[i];
            }
            return res;
        }    
        static string getText(string t, params int[] a) 
        {

            string res = "";
            for (int i = 0; i<a.Length ; i++) 
            {
                res += t[a[i]];
            }
            return res;     
        }
        static void show(int[] a, params char[] b)
        {

            Console.Write("Чисел "+a.Length+": ");
            for (int i = 0;i < a.Length ; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("и " + a[a.Length - 1]);
            Console.WriteLine("Символов " + b.Length+" ");
            for (int i = 0; i < b.Length - 1; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("и " + b[b.Length - 1]);

        }
        static void Main()
        {
            
            Console.WriteLine("Сумма чисел: " + sum(1, 6, 9, 2, 4));
            Console.WriteLine("Сумма чисел: " + sum(1, 5, 2 ));
            Console.WriteLine(getText("Раз Два Три", 0, 10, 8, 1));
            Console.WriteLine(getText("Бревно", 3, 5, 1, 5, 4));
            show(new int[] { 1, 3, 5 }, 'A', 'B', 'C', 'D', 'E');
            show(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C', 'D');

        }

































    }
}
