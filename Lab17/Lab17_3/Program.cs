using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите K: ");
            k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            if (k <= 0)
            {
                Console.WriteLine("Wrong value of K!");
                Environment.Exit(1);
            }

            int nS1 = 1, lS1 = 1, elS1 = a[0], pS1 = 0, lS2 = 1, elS2 = a[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] == a[i - 1])
                {
                    lS2++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (nS1 != k)
                {
                    if (a[i] != a[i + 1])
                    {
                        elS1 = a[i + 1];
                        nS1++;
                    }
                }
                else
                {
                    pS1 = i;
                    for (int j = i; ; j++)
                    {
                        if (a[j] == a[j + 1])
                        {
                            lS1++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
            }

            int index = 0;
            for (int i = 0; i <= n - lS2; i++, index++)
            {
                b[index] = a[i];
                if (i == pS1)
                {
                    for (; index < i + lS2; index++)
                    {
                        b[index] = elS2;
                    }
                    i += lS1 - 1;
                    index--;
                }
                if (i == n - lS2)
                {
                    for (; index < n; index++)
                    {
                        b[index] = elS1;
                    }
                }

            }

            Console.WriteLine("Массив B: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
