using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полный путь файла: ");
            string s = Console.ReadLine();
            int index = -1, index_1 = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    index = i;
                    break;
                }
            }
            for (int i = s.Length - 1; i > -1; i--)
            {
                if (s[i] == '\\')
                {
                    index_1 = i;
                    break;
                }
            }

            if (index != -1 && index_1 != -1 )
            {
                for (int i = index_1 + 1; i < index; i++)
                {
                    Console.Write(s[i]);
                }
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
            Console.WriteLine("");
        }
    }
}
