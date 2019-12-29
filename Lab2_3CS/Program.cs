using System;
namespace Lab2_3CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("Произведение длин отрезков AC и BC: ");
            Console.WriteLine(Math.Abs(a - c) * Math.Abs(b - c));
        }
    }
}
