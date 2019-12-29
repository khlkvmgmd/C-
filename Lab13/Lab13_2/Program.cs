using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, d;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите D: ");
            d = int.Parse(Console.ReadLine());
            double[] list = new double[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = a * Math.Pow(d, i);
                Console.Write(list[i] + " ");
            }
        }
    }
}
