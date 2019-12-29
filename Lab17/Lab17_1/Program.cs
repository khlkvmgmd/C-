using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 1, x = 1, y = 0, k = 1;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (a[i] != a[i - 1])
                {
                    count += 1;
                }
            }
            int[] b = new int[count];
            int[] c = new int[count];
            c[0] = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] == a[i - 1])
                {
                    k++;
                }
                else
                {
                    c[x] = a[i];
                    x++;
                    b[y] = k;
                    y++;
                    k = 1;
                }
            }
            b[y] = k;
            Console.WriteLine("Массив B: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(b[i]+ " ");                  
            }
            Console.WriteLine("");
            Console.WriteLine("Массив C: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
