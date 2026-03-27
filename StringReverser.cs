using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeThingMine
{
    internal class Program
    {
        static string WR(string a)
        {

            char[] chars = a.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        
        }
        static void Main() 
        {

            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            string reversedWord = WR(word);

            Console.WriteLine("Слово наоборот: " + reversedWord);

        }































    }
}
