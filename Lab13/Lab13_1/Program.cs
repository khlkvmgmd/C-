using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b = 1;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = b;
                b += 2;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
