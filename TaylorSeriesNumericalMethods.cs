 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class MyMath
    {
        public const double pi =3.141592;
        public static int N = 100;
        public static double exp(double x)
        {
            double s = 0, q = 1;
            for (int i = 0; i <= N; i++)
            {
                s+= q;
                q*=x/(i+1);
            }
            return s;
        }
        public static double sin(double x)
        {
            double s = 0, q = x;
            for (int i = 0; i <= N; i++)
            {
                s += q;
                q *=(-1)*x*x/(2*i+2)/(2*i+3);
            }
            return s;
        }
    }
    class Staticdemo
    {
        static void Main()
        {
            
            double z = 1;
            Console.WriteLine("exp({0})={1}",z,MyMath.exp(z));
            Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));
            z = MyMath.pi / 4;
            Console.WriteLine("sin({0})={1}", z, MyMath.sin(z));
            Console.WriteLine("Контрольное значение : {0}", Math.Sin(z));
        }
    }
}
