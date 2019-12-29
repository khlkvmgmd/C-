using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Введите M: ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[m, m];
            for (int i = 0; i < m; i++)
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
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine("");
            }

            int[] sum = new int[m + (m - 1)];
            int index = 0, step = 0;
            for (int i = m - 1; i >= 0; i--)
            {
                int j = i;
                while (j < m)
                {
                    sum[index] += a[step, j];
                    j++;
                    step++;
                }
                step = 0;
                index++;
            }
            for (int i = 1; i < m; i++)
            {
                int j = 0;
                while (i + step < m)
                {
                    sum[index] += a[i + step, j];
                    j++;
                    step++;
                }
                step = 0;
                index++;
            }

            Console.Write("\nРезультат: \n");

            for (int i = 0; i < m + (m - 1); i++)
            {
                Console.Write(sum[i] + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
