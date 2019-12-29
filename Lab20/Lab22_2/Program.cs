using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab22_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название файла: ");
            string file = Console.ReadLine();
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите K: ");
            int k = int.Parse(Console.ReadLine());
            string s = "";
            string[] s1 = new string[n];
            for (int i = 0; i < k; i++)
            {
                s = s.Insert(i, "*");
            }
            for (int i = 0; i < n; i++)
            {
                s1[i] = s;
            }
            File.WriteAllLines(file, s1);
        }
    }
}
