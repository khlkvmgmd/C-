using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, k;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите M: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Введите K: ");
            k = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"[{i + 1}][{j + 1}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0, mult = 1;
            for (int i = 0; i < m; i++)
            {
                sum += a[k - 1, i];
                mult *= a[k - 1, i];
            }

            Console.WriteLine($"\nСумма ряда номер {k}: {sum}");
            Console.WriteLine($"Произведение ряда номер {k}: {mult}\n");
        }
    }
}
