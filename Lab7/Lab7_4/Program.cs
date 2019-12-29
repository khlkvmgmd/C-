using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;
            Console.Write("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = n / 100;
            b = (n - a * 100) / 10;
            c = n % 10;
            if (a < b && b < c)
            {
                Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность");
            }
            else if (a > b && b > c) { 
                Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность");
            }
            else { Console.WriteLine("Цифры данного числа НЕ образуют возрастающую или убывающую последовательность");
            }
        }
    }
}
