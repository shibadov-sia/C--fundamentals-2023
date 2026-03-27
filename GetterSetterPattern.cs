using System;

namespace ConsoleApp29
{
    class MyClass
    {
        private int code;
        public int get()
        {
            return this.code;
        }
        public void set(int code)
        {
            this.code = code;
        }
        public MyClass(int code)        {
            this.code = code;
            Console.WriteLine("Создан обьект: "+this.get());
        }
    }
    class UTD
    {
        static void Main()
        {
            MyClass obj=new MyClass(100);
            obj.set(200);
            Console.WriteLine("Новое значение: "+obj.get());
        }
    }
}
