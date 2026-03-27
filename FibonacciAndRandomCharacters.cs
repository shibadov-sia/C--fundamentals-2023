using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static int[] fibs(int n)
        {
            int[] nums = new int[n];
            nums[0] = 1;
            if (nums.Length == 1) return nums;
            nums[1] = 1;
            for (int k = 2; k < nums.Length; k++) 
            {
                nums[k] = nums[k-1]+ nums[k-2];
            }
            return nums;
        }
        static char[] rands(int n)
        {
            Random rnd = new Random();
            char[] symbs = new char[n];
            for (int k = 0; k<symbs.Length; k++)
            {
                symbs[k] = (char)('A'+rnd.Next(26));
            }
        return symbs;
        
        
        }
    
        static int[,] odds(int m, int n)
        {
            int[,] nums=new int[m,n];
            int val = 1;
            for(int i = 0;i<nums.GetLength(0);i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = val;
                    val += 2;
                }
            }
            return nums;
        
        }
    
        static void Main()
        {
            int[] a;
            char[] b;
            int[,] c;
            a = fibs(10);
            Console.WriteLine("числа фибоначчи:");
            foreach (int s in a)
            {
                Console.Write("| {0}", s);
            }
            Console.WriteLine("|");
            
            b = rands(8);
            Console.WriteLine("Случаые символы");
            foreach(char s in b)
            {
                Console.Write("| {0}", s);
            }
            Console.WriteLine("|");
            c = odds(4,6);
            Console.WriteLine("Двумерный массив:");
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write("{0,4}", c[i,j]) ;
                }
                Console.WriteLine();
            }
        }
    }
}
