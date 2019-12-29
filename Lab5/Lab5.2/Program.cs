using System;
namespace Lab5._2
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
            Console.Write("Количество отрезков B, размещенных на отрезке A: ");
            Console.WriteLine(a / b);
        }
    }
}