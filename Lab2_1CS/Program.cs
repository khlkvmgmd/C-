using System;
namespace Lab2_1CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            float y2 = float.Parse(Console.ReadLine());
            double a, b;
            a = Math.Pow(Math.Abs(x2 - x1), 2);
            b = Math.Pow(Math.Abs(y2 - y1), 2);
            Console.Write("Расстояние между точками равно: ");
            Console.WriteLine(Math.Pow(a + b, 0.5));
        }
    }
}