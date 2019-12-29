using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: "); 
            string s = Console.ReadLine();          
            Console.Write("Результат: ");
            for (int i = 1; i < s.Length; i += 2)
            {
                Console.Write(s[i]);
            }
            if (s.Length % 2 == 0)
            {
                for (int i = s.Length - 2; i > -1; i-=2)
                {
                    Console.Write(s[i]);
                }
            }
            else
            {
                for (int i = s.Length - 1; i > -1; i -= 2)
                {
                    Console.Write(s[i]);
                }
            }
            Console.WriteLine("");
        }
    }
}
