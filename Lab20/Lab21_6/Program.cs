using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полный путь файла: ");
            string s = Console.ReadLine();
            int x, k = 0, y;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == '.' && s[j] == '\\')
                    {
                        y = i;
                        x = j;
                        k++;
                    }
                }
            }
            for (int i = 0; i < x; i++)
            {
                if (s[x - i - 1] == '\\')
                {
                    k = x - i;
                    break;
                }
            }
            if (k - 1 == 0)
            {
                Console.Write("Название последнего каталога: \\" );
            }
            else
            {
                Console.Write("Название последнего каталога: ");
                for (int i = 0; i < x - k; i++)
                {
                    Console.Write(s[k + i]);
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("");
        }
    }
}
