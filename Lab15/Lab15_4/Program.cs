using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min_i=0, max_i=0, r;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    max_i = i;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    min_i = i;
                }
            }

            r= Math.Abs(min_i - max_i);
            if (r == 1)
            {
                Console.Write("Массив не изменился: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine("");
            }
            else
            {
                if (min_i < max_i)
                {
                    for (int i = min_i+1; i < max_i; i++)
                    {
                        a[i] = 0;
                    }
                    Console.Write("Массив после преобразований: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(a[i] + " ");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    for (int i = max_i+1; i < min_i; i++)
                    {
                        a[i] = 0;
                    }
                    Console.Write("Массив после преобразований: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(a[i] + " ");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
