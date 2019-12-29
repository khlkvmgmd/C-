using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k1=0, k2=0, count=0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        k1 = i;
                        k2 = j;
                        count += 1;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("В массиве нет одинаковых элементов");
            }
            else if (count == 1)
            {
                Console.WriteLine("Одинаковые элементы с индексами: " + k1 + " и " + k2);
            }
            else
            {
                Console.WriteLine("В массиве больше двух одинаковых элементов.");
            }
            Console.WriteLine();
        }
    }
}
