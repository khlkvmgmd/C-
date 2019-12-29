using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива A: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива B: ");
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                t = a[i];
                a[i] = b[i];
                b[i] = t;
            }
            Console.Write("Массив A: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
            Console.Write("Массив B: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
