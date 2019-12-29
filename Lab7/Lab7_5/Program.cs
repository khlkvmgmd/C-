using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c, d;
            Console.Write("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = n / 1000;
            b = (n - a * 1000) / 100;
            c = (n - a * 1000 - b * 100) / 10;
            d = n % 10;
            if (a == d && b == c)
            {
                Console.WriteLine("Данное число читается одинаково слева направо и справа налево");
            }
            else { Console.WriteLine("Данное число НЕ читается одинаково слева направо и справа налево"); }
        }
    }
}
