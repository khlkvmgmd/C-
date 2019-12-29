using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полный путь файла: ");
            string s = Console.ReadLine();
            int x = -1, y = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    x = i;
                }
            }
            if (x == -1) 
            {
                for (int i = s.Length-1; i > -1; i--)
                {
                    if (s[i] == '\\')
                    {
                        y = i;
                    }
                }
                if (y == -1) 
                {
                    Console.WriteLine("Ошибка");
                }
                else 
                { 
                    Console.WriteLine("\\");
                }
            }
            else
            {
                for (int i = s.Length - 1; i > -1 ; i--)
                {
                    if (s[i] == '\\')
                    {
                        y = i;
                        break;
                    }
                }
                if (y == -1)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    Console.Write("Название последнего каталога: ");
                    for (int i = y + 1; i < x; i++)
                    {
                        Console.Write(s[i]);
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
