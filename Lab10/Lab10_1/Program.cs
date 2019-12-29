using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("Введите число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("0,1 кг - " + a / 10);
            Console.WriteLine("0,2 кг - " + a / 5);
            Console.WriteLine("0,3 кг - " + a / 10 * 3);
            Console.WriteLine("0,4 кг - " + a / 10 * 4);
            Console.WriteLine("0,5 кг - " + a / 2);
            Console.WriteLine("0,6 кг - " + a / 10 * 6);
            Console.WriteLine("0,7 кг - " + a / 10 * 7);
            Console.WriteLine("0,8 кг - " + a / 10 * 8);
            Console.WriteLine("0,9 кг - " + a / 10 * 9);
            Console.WriteLine("1 кг - " + a);
        }
    }
}
