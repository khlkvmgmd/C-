using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_2
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
                    Console.Write($"[{i + 1}][{j + 1}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine("");
            }

            int min = a[0, 0], max = a[0, 0];
            int min_colomn = 0, max_colomn = 0, temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        max_colomn = j;
                    }
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        min_colomn = j;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp = a[j, max_colomn];
                    a[j, max_colomn] = a[j, min_colomn];
                    a[j, min_colomn] = temp;
                }
            }

            Console.WriteLine("\nИзмененная матрица: \n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
