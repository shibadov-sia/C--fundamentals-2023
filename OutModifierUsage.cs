using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static int getMin(int[] nums, out int index)
        {
        
        index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < nums[index]) { 
                index = i;}
            }
         return nums[index];
        
        }
        static void Main()
        {
        
            int[] a = { 12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15 };
            foreach (int v in a) 
            { 
            Console.Write("| {0}", v);
            }
        Console.WriteLine("|");
        int val, k;
        val = getMin(a, out k);
        Console.WriteLine("Наименьшее значение: "+val);
        Console.WriteLine("Индекс элемента: "+k);
        Console.WriteLine("Проверка: А[{0}]={1}", k, a[k]);

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
