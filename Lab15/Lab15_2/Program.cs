using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double k;
            double sum = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива A: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                k = i+1;
                sum += a[i];
                b[i] = sum / k;
            }
            Console.Write("Массив B: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " | ");
            }
        }
    }
}
