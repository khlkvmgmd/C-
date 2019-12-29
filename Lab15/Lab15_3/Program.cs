using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i > 0; i--)
            {
                if (a[i] % 2 == 1)
                {
                    k = a[i];
                    break;
                }
            }
            Console.Write("Массив после преобразований: ");
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    a[i] = k;
                }
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
