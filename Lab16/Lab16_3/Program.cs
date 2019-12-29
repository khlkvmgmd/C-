using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max, x = 0, y = 0, min, k=0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n+2];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }

            min = a[0];
            max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    x = i;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    y = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] == max)
                {
                    k += 1;
                }
                if (a[i] == min)
                {
                    k += 1;
                }
            }
            if (k > 2)
            {
                Console.WriteLine("В массиве больше одного минимального (максимального) элемента");
            }
            else
            {
                for (int i = 0; i < n + 2; i++)
                {
                    if (i == x)
                    {
                        for (int j = n-1; j > i+1; j--)
                        {
                            b[j] = b[j - 1];
                        }
                        b[i + 1] = 0;
                    }
                }
                for (int i = 0; i < n + 2; i++)
                {
                    if (i == y)
                    {
                        for (int j = n + 1; j > i; j--)
                        {
                            b[j] = b[j - 1];
                        }
                        b[i] = 0;
                    }
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
