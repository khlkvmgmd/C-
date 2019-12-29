using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, k = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " неодинаковых чисел: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            d = a[1] - a[0];
            for (int i = 2; i < n; i++)
            {
                if (a[i] - a[i - 1] == d)
                {
                    continue;
                }
                else
                {
                    k += 1;
                    break;
                }
            }
            if (k > 0)
            {
                Console.WriteLine("Не образует арифметическую прогрессию: " + 0);
            }
            else
            {
                Console.WriteLine("Образует арифметическую прогрессию с разницей: " + d);
            }
        }
    }
}
