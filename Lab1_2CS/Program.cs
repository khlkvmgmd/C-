using System;
namespace Lab1_2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double d,l;
            const double pi = 3.14;
            Console.Write("Введите диаметр: ");
            d = Convert.ToDouble(Console.ReadLine());
            l = pi * d;
            Console.Write("Длина окружности: ");
            Console.WriteLine(l);
        }
    }
}
