using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void fillRand(int[] nums)
        {
        Random rnd = new Random();
            for (int k = 0; k < nums.Length; k++)
            {
            nums[k]=rnd.Next(1,101);
            }
            
        }
        static void showArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("| {0}", nums[i]);
            }
            Console.WriteLine("|");
        }

        static void showArray(int[,] nums)
            {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write("{0,3}", nums[i, j]);
                }
            Console.WriteLine();
            }
        }
        static int findMin(int[] nums)
        {
            int s = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < s) s = nums[i];
            }
            return s;
        }
        static void Main()
        {
            int[] A = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] B = new int[5];
            int[,] C = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            fillRand(B);
            Console.WriteLine("Одномерный массив А:");
            showArray(A);
            Console.WriteLine("Одномерный массив В:");
            showArray(B);
            
            int m = findMin(B);
            Console.WriteLine("Наименьшее значение: {0}", m);

            Console.WriteLine("Двумерный массив С:");
            showArray(C);
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
