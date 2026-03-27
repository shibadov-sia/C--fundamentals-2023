using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void alpha(int n)
        {
            
            Console.WriteLine("В методе alpha(). на входе:" + n);
            n++;
            Console.WriteLine("В методе alpha(). на выходе:" + n);

        }
        static void bravo(int[] n)
        {
            
            Console.WriteLine("В методе bravo(). на входе:"+ArrayToText(n));
            for (int i = 0; i < n.Length; i++)
            {
                n[i]++;
            }
            Console.WriteLine("В методе bravo(). на выходе:" + ArrayToText(n));
        }
        static void charlie(int[] n)
        {
        
            Console.WriteLine("В методе charlie(). на входе:" + ArrayToText(n));
            int[] m = new int[n.Length];
            for (int i = 0;i < n.Length; i++)
            {
                m[i] = n[i]+1;
            }
            n = m;
            Console.WriteLine("В методе charlie(). на выходе:" + ArrayToText(n));
        }
        static string ArrayToText(int[] n)
        {
            
            string res = "[" + n[0];
            for (int i = 1; i < n.Length; i++)
            {
                res += "," + n[i];
            }
            res += "]";
            return res;
        }
        static void Main()
        {

            int A = 100;
            Console.WriteLine("До вызова метода alpha(): A="+A);
            alpha(A);
            Console.WriteLine("После вызова метода alpha() A="+A);
            int[] B = { 1, 3, 5 };
            Console.WriteLine("До вызова метода Bravo(): B=" + ArrayToText(B));
            bravo(B);
            Console.WriteLine("После вызова метода Bravo(): B=" +ArrayToText(B));
            int[] C = { 2, 4, 6 };
            Console.WriteLine("До вызова метода charlie(): C=" + ArrayToText(C));
            charlie(C);
            Console.WriteLine("После вызова метода charlie(): C=" + ArrayToText(C));

        }











































    }
}
