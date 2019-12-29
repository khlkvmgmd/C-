using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите x{0}: ", i + 1);
                a[i, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите y{0}: ", i + 1);
                a[i, 1] = int.Parse(Console.ReadLine());
            }

            int[] b = new int[n];
            double max_P = 0, temp = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        temp = Math.Sqrt(Math.Abs((Math.Pow(a[i, 0], 2) - Math.Pow(a[j, 0], 2)) + (Math.Pow(a[i, 1], 2) - Math.Pow(a[j, 1], 2))))
                             + Math.Sqrt(Math.Abs((Math.Pow(a[j, 0], 2) - Math.Pow(a[k, 0], 2)) + (Math.Pow(a[j, 1], 2) - Math.Pow(a[k, 1], 2))))
                             + Math.Sqrt(Math.Abs((Math.Pow(a[k, 0], 2) - Math.Pow(a[i, 0], 2)) + (Math.Pow(a[k, 1], 2) - Math.Pow(a[i, 1], 2))));
                        if (temp > max_P)
                        {
                            max_P = temp;
                            b[0] = i;
                            b[1] = j;
                            b[2] = k;
                        }
                    }
                }
            }

            Console.WriteLine($"Наибольший периметр треугольника = {Convert.ToSingle(max_P)}. Он состоит из точек:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Точка {b[i] + 1} с координатами ({a[b[i], 0]}, {a[b[i], 1]})");
            }
        }
    }
}
