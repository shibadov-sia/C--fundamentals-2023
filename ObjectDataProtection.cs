using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class myclass
    {
        private int nu;
        private char sy;
        public void show()
        {
            Console.WriteLine("Поле обьекта: "+nu+" и "+sy);
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

    }
}
