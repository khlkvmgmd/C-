using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, l = 1;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] c = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            c[0] = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] == a[i - 1])
                {
                    continue;
                }
                else
                {
                    c[l] = a[i];
                    l += 1;
                }
            }
            Array.Resize(ref c, l);

            Console.Write("Массив после преобразований: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
