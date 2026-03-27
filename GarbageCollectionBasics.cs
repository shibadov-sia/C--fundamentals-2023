using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Myclass
    {
        private string name;
        public Myclass(string txt) 
        {
            name = txt;
            Console.WriteLine("Создан обьект \"{0}\"", name);
        }
        ~Myclass() 
        {
            Console.WriteLine("Удален обьект\"{0}\"",name);
        }
    }
    class DD
    {
        static void Maker(string txt) 
        { 
            new Myclass(txt);
        }
        static void Main() 
        {
            Myclass A = new Myclass("Первый");
            new Myclass("Второй");
            A = new Myclass("Третий");
            Maker("Четвертый");
            A=new Myclass("Пятый");
        }
    }
}
