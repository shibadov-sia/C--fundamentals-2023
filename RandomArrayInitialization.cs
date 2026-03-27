using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void rand(int[] num)
        {
        Random rnd = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1,101);
            }
        }
        static void Main(string[] args) 
        {
            int[] B = new int[20];
            rand(B);
            Console.WriteLine(B);








        } 
    }
}
