using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaB17_4
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

            bool flag = true;
            int max = 0;
            double result;
            for (int i = 0; i < n; i++)
            {
                if (a[i, 0] < 0 && a[i, 1] > 0)
                {
                    flag = false;
                    if (Math.Abs(a[i, 0]) + Math.Abs(a[i, 1]) > max)
                    {
                        max = i;
                    }
                }
            }

            if (flag == true)
            {
                Console.WriteLine("Нет точек, лежащих во второй четверти -- (0, 0)");
            }
            else
            {
                result = Math.Sqrt(Math.Pow(a[max, 0], 2) + Math.Pow(a[max, 1], 2));
                Console.WriteLine("Наиболее удаленная точка от начала координат во второй четверти:");
                Console.WriteLine($"Точка {max + 1} с координатами ({a[max, 0]}, {a[max, 1]})\nРасстояние от начала координат = {Convert.ToSingle(result)}");
            }
        }
    }
}
