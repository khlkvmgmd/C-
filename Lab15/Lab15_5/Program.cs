using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k0, k1, t;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            k0 = 0;
            k1 = 1;
            while (a[k0] > a[k1])
            {
                t = a[k1];
                a[k1] = a[k0];
                a[k0] = t;
                k0 += 1;
                k1 += 1;
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
