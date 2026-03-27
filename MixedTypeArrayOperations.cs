using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object[] objs =new Object[3];
            objs[0] = 123;
            objs[1] = 'A';
            objs[2] = "third element";
            Console.WriteLine("Создан такой массив:");
            for (int i = 0; i < objs.Length; i++)
            {
                Console.WriteLine(i+": " + objs[i]);
            }
            objs[0] = (int)objs[0]+111;
            objs[1] = "second element";
            objs[2] = 3.141592;
            Console.WriteLine("После присва");
            for (int k = 0;k < objs.Length; k++) 
            {
                Console.WriteLine(k+": " + objs[k]);
            }
            int[] nums = { 10, 20, 30 };
            objs[2] = nums;
            Console.WriteLine("Целоисленный массив");

            for(int k = 0; k < ((int[])objs[2]).Length; k++) { 
            Console.WriteLine("{0,3}"+nums);
            }
            Console.WriteLine();
            ((int[])objs[2])[1] = 0;
            Console.WriteLine("Еще раз тот же массив");
            for(int i = 0; i < objs.Length - 1; i++) {
                Console.WriteLine("{0,3}", nums[i]);
            }












































            Console.ReadLine();
        }
    }
}
