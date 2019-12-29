using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, l, count = 0, k = 1, x = 0;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите L: ");
            l = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("Введите " + n + " чисел массива: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    if (a[i] == a[i + 1])
                    {
                        k++;
                    }
                    else
                    {
                        if (k > l)
                        {
                            b[x] = 0;
                            x++;
                            k = 1;
                            count++;
                        }
                        else
                        {
                            count += k;
                            int temp = a[i];
                            for (int j = 0; j < k; j++)
                            {
                                b[x] = temp;
                                x++;
                            }
                            k = 1;
                        }
                    }
                }
                else
                {
                    if (k > l)
                    {
                        b[x] = 0;
                        x++;
                        k = 1;
                        count++;
                    }
                    else
                    {
                        count += k;
                        int temp = a[i];
                        for (int j = 0; j < k; j++)
                        {
                            b[x] = temp;
                            x++;
                        }
                        k = 1;
                    }
                }
            }
            Array.Resize(ref b, count);
            //вывод измененного массива А
            Console.WriteLine("Массив B: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
