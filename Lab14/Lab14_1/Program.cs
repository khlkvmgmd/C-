using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, l;
            double sum = 0, kol = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите K: ");
            k = int.Parse(Console.ReadLine()); 
            Console.Write("Введите L: ");
            l = int.Parse(Console.ReadLine());
            for (int i = k-1; i <= l-1; i++)
            {
                sum += a[i];
                kol += 1;
            }
            Console.WriteLine("Среднее арифметическое: " + sum/kol);
        }
    }
}
