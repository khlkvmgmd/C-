using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название файла: ");
            string file = Console.ReadLine();
            int x = -1;
            if (File.Exists(file))
            {
                string s = File.ReadAllText(file);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        x = i;
                        break;
                    }
                }
                if (x == -1)
                {
                    Console.WriteLine("Пробелов в тексте нет");
                }
                else
                {
                    string s1 = s.Remove(0, x+1);
                    File.WriteAllText(file, s1);
                    Console.WriteLine("Готово!");
                }
            }
            else
            {
                Console.WriteLine("Неверное название файла");
            }
        }
    }
}