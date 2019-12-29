using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первый файл: ");
            string file1 = Console.ReadLine(); 
            Console.Write("Второй файл: ");
            string file2 = Console.ReadLine();
            if (File.Exists(file1) && File.Exists(file2))
            {
                string s2 = File.ReadAllText(file2);
                string s1 = File.ReadAllText(file1);
                s1 = s1.Insert(0, s2);
                File.WriteAllText(file1, s1);
                Console.WriteLine("Готово");
            }
            else
            {
                Console.WriteLine("Файлы не найдены");
            }
        }
    }
}
