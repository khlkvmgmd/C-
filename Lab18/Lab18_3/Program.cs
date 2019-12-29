using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_3
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

            int[] pr = new int[m];
            int min = pr[0], index = 0;
            bool flag = true;
            for (int i = 0; i < m; i++)
            {
                pr[i]++;
                for (int j = 0; j < n; j++)
                {
                    pr[i] *= a[j, i];
                }
                if (flag == true)
                {
                    min = pr[i];
                    flag = false;
                }
                if (pr[i] < min)
                {
                    min = pr[i];
                    index = i;
                }
            }

            Console.WriteLine($"\nСтолбец с наименьшим произведением под номером: {index + 1}.\nПроизведение = {min}\n");
        }
    }
}
