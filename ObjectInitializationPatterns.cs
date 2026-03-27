using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class MyClass
    {
        public int num;
        public char symb;
        public string txt;
        public void show()
        {
            Console.WriteLine("Поля: {0},\'{1}\' и \"{2}\"", num, symb, txt);
        }
        public MyClass()
        {
            num = 100;
            symb = 'А';
            txt = "Красный";
        }
        
        public MyClass(int n)
        {
            num = n;
            symb = 'B';
            txt = "Желтый";
        }
        public MyClass(int n, char s)
        {
            num = n;
            symb = s;
            txt = "Зеленый";
        }
        public MyClass(int n, char s, string t)
        {
            num = n;
            symb = s;
            txt =t;
        }
        public MyClass(string t)
        {
            num = 0;
            symb = 'Z';
            txt = t;
        }
    }
    class CD
    {
        static void Main() 
        { 
            MyClass A = new MyClass();
            A.show();
            MyClass B = new MyClass(200);
            B.show();
            MyClass C = new MyClass(300,'C');
            C.show();
            MyClass D = new MyClass(400,'D',"Синий");
            D.show();
            MyClass E = new MyClass('A');
            E.show();
            MyClass F = new MyClass("Серый");
            F.show();
        }
    }
}
