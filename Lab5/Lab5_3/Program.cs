using System;
namespace Lab5_3
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.Write("Введите A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Длина незанятой части отрезка A: ");
            Console.WriteLine(a - a / b * b);
        }
    }
}