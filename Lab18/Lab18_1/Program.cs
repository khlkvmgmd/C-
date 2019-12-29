using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Введите M: ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"[{i + 1}][{j + 1}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine(" \nРезультат:\n======");
            int amount_elem = 0, max_elem = m * m, count = 0;
            while (true)
            {
                if (amount_elem == (max_elem)) { break; }

                for (int i = 0 + count; i < m - count; i++)
                {
                    Console.Write(a[i, count] + " ");
                    amount_elem++;
                }
                if (amount_elem == (max_elem)) { break; }

                for (int i = 1 + count; i < m - count; i++)
                {
                    Console.Write(a[m - 1 - count, i] + " ");
                    amount_elem++;
                }
                if (amount_elem == (max_elem)) { break; }

                for (int i = m - 2 - count; i > -1 + count; i--)
                {
                    Console.Write(a[i, m - 1 - count] + " ");
                    amount_elem++;
                }
                if (amount_elem == (max_elem)) { break; }
                count++;

                for (int i = m - 1 - count; i > count - 1; i--)
                {
                    Console.Write(a[count - 1, i] + " ");
                    amount_elem++;
                }
                if (amount_elem == (max_elem)) { break; }
            }
            Console.WriteLine("\n");
        }
    }
}
