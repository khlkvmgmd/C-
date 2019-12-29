using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите M: ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"[{i + 1}][{j + 1}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] b = new int[m];
            int[] count = new int[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i] += a[j, i];
                }
                b[i] /= n;
                for (int j = 0; j < n; j++)
                {
                    if (a[j, i] > b[i])
                    {
                        count[i]++;
                    }
                }
            }

            Console.Write("\n\nНомера столбцов\t|");
            for (int i = 0; i < m; i++)
            {
                Console.Write($" {i + 1}\t|");
            }
            Console.Write("\nКоличество\t|");
            for (int i = 0; i < m; i++)
            {
                Console.Write($" {count[i]}\t|");
            }
            Console.WriteLine("\n");
        }
    }
}
