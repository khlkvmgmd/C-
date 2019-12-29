using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 0, x = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0 || a[i] == 0)
                {
                    count++;
                }
            }
            int[] b = new int[n + count];

            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    b[x] = a[i];
                    x++;
                }
                else
                {
                    b[x] = 0;
                    x++;
                    b[x] = a[i];
                    x++;
                }
            }

            Console.Write("Массив после преобразований: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
