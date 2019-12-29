using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, min;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            min = a[1];
            for (int i = 3; i < n; i+=2)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Минимальное число с четным номером: " + min);
        }
    }
}
