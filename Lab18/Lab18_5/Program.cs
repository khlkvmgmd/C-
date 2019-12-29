using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_5
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

            int index = -1;
            bool flag = true;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j, i] % 2 == 0)
                    {
                        if (a[j, i] != 0)
                        {
                            flag = false;
                        }
                    }
                }
                if (flag == true)
                {
                    index = i;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            Console.WriteLine();
            if (index != -1)
            {
                Console.WriteLine($"Столбец, состоящий из нечетных чисел, имеет номер {index + 1}");
            }
            else
            {
                Console.WriteLine("Столбец, состоящий из нечетных чисел, отсутствует в матрице\n0");
            }
            Console.WriteLine();
        }
    }
}
