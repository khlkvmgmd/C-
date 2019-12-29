using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] charSeparators = { ' ' } ;
            string[] result = s.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов: " + result.Length);
        }
    }
}
