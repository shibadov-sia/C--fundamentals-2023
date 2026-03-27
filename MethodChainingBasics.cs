using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class myclass
    {
        private int nu;
        private char sy;
        public void show()
        {
            Console.WriteLine("Поля обьекта: " + nu + " и " + sy);
        }
        public void set(int n, char s)
        {
            nu = n;
            sy = s;
        }
        public void set(int n)
        {
            nu = n;
            sy = 'B';
        }
        public void set()
        {
            set(100, 'A');
        }
    
    }
    class MD
    {
        static void Main()
        {
            
            myclass obj = new myclass();
            obj.set();
            obj.show();
            obj.set(200);
            obj.show();
            obj.set(300,'C');
            obj.show();
        }
    }
}




