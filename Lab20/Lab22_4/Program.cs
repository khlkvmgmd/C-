using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab22_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            string file = Console.ReadLine();
            if (File.Exists(file))
            {
                string s = File.ReadAllText(file);
                var ans = new Regex(@"\s+").Replace(s, " ");
                Console.WriteLine(ans);
                File.WriteAllText(file, ans);
                Console.WriteLine("Готово");
            }
            else
            {
                Console.WriteLine("Файлы не найдены");
            }
        }
    }
}
