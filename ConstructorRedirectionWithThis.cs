using System;


namespace ConsoleApp31
{
    class MyClass
    {
        public int alpha;
        public int bravo;
        public MyClass(int a) 
        { 
            Console.WriteLine("Конструктор с одним аргументом");
            alpha = a;
            bravo = alpha;
            Console.WriteLine("Оба поля равны "+alpha);
        }
        public MyClass(int a, int b): this(a) 
        {
            Console.WriteLine("Конструктор с двумя аргументами ");
            bravo = b;
            Console.WriteLine("Поля "+alpha+" и "+bravo);
        } 

    }
}
