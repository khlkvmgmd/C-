using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lmax = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            if (a[0] > a[1])
            {
                lmax = a[0];
            }
            for (int i = 1; i < n-1; i++)
            {
                if (a[i - 1] < a[i] && a[i] > a[i + 1])
                {
                    lmax = a[i];
                }
            }
            if (a[n - 1] > a[n - 2])
            {
                lmax = a[n - 1];
            }
            if (lmax == 0)
            {
                Console.WriteLine("Локального максимума в данном массиве нет!");
            }
            else
            {
                Console.WriteLine("Последний локальный максимум: " + lmax);
            }
        }
    }
}