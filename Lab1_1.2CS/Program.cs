using System;

namespace Lab1_1._2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s, p;
            Console.Write("Введите сторону A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону B: ");
            b = Convert.ToDouble(Console.ReadLine());
            s = a * b;
            p = 2 * (a + b);
            Console.Write("Площадь: ");
            Console.WriteLine(s);
            Console.Write("Периметр: ");
            Console.WriteLine(p);
        }
    }
}
