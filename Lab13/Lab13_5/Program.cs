using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i+=2)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            if (n % 2 == 1)
            {
                for (int i = n - 1; i >= 0; i -= 2)
                {
                    Console.Write(list[i] + " ");
                }
            }
            else 
            {
                for (int i = n - 2; i >= 0; i -= 2)
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
    }
}
