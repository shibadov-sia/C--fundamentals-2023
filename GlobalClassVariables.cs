using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class MyClass
    {

        public static int code = 100;
        public static void show()
        {
            Console.WriteLine("Статические поля: "+code);
        }
    class StaticDemo
        {
            static void Main()
            {
                MyClass.show();
                MyClass.code=200;
                MyClass.show();
            }
        }
    }
}
