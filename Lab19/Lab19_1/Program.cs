using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_1
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

            int min, max, temp;
            for (int i = 0; i < n; i++)
            {
                min = 0;
                max = 0;
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > a[i, max])
                    {
                        max = j;
                    }
                    if (a[i, j] < a[i, min])
                    {
                        min = j;
                    }
                }
                temp = a[i, min];
                a[i, min] = a[i, max];
                a[i, max] = temp;
            }

            Console.WriteLine("\nИзмененный массив: \n");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write(a[j,i] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
