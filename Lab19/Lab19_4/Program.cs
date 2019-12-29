using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, temp;
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

            for (int i = 1; i < n; i++)
            {
                if (a[i - 1, 0] > a[i, 0])
                {
                    for (int x = 0; x < a.GetLength(1); x++)
                    {
                        temp = a[i - 1, x];
                        a[i - 1, x] = a[i, x];
                        a[i, x] = temp;
                    }
                    for (int j = i - 1; j > 0; j--)
                    {
                        if (a[j - 1, 0] > a[j, 0])
                        {
                            for (int x = 0; x < a.GetLength(1); x++)
                            {
                                temp = a[j - 1, x];
                                a[j - 1, x] = a[j, x];
                                a[j, x] = temp;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
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
