using System;


namespace ConsoleApp21
{
    class myclass
    {
        
        public int n;
        
        public char s;
        
        public void show()
        {
            Console.WriteLine("целое число " + n);
            Console.WriteLine("символ " + s);
        }
    }
    class UOD
    {
        static void Main()
        {
            myclass a = new myclass();
            myclass b;
            b = new myclass();
            a.n = 123;
            a.s = 'a';
            b.n = 321;
            b.s = 'b';
            Console.WriteLine("Первый обьект: ");
            a.show();
            Console.WriteLine("Второй обьект: ");
            b.show();
        }

    }
}
