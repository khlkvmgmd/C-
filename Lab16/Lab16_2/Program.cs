using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0, m = 0, count=0, x, l=0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        k += 1;
                    }
                }
                if (k == 1)
                {
                    b[m] = a[i];
                    m += 1;
                }
                k = 0;
            }

            Array.Resize(ref b, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i] == b[j])
                    {
                        k += 1;
                    }
                }
                if (k == 1) 
                {
                    count += 1;
                }
                else
                {
                    c[l] = a[i];
                    l++;
                }
                k = 0;
            }
            Array.Resize(ref c, l);

            Console.Write("Массив после преобразований: ");
            for (int i = 0; i < l; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
