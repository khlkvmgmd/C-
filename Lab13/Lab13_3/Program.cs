using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            b = int.Parse(Console.ReadLine());
            int[] list = new int[n];
            list[0] = a;
            list[1] = b;
            list[2] = a + b;
            Console.Write(list[0] + " ");
            Console.Write(list[1] + " ");
            Console.Write(list[2] + " ");
            for (int i = 3; i < n; i++)
            {
                list[i] = list[i - 1] * 2;
                Console.Write(list[i] + " ");
            }
        }
    }
}