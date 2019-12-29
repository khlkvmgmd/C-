using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_3
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

            int temp;
            int hor_index = m / 2, vert_index = n / 2;
            if (m % 2 != 0)
            {
                hor_index++;
            }
            if (n % 2 != 0)
            {
                vert_index++;
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    temp = a[i, j];
                    a[i, j] = a[i + vert_index, j + hor_index];
                    a[i + vert_index, j + hor_index] = temp;
                }
            }

            Console.WriteLine("\nИзмененный массив: \n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
