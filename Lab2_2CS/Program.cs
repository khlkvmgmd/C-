using System;
namespace Lab2_2CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите точку A: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введите точку B: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Введите точку C: ");
            float c = float.Parse(Console.ReadLine());
            double AC = Math.Abs(a - c);
            double BC = Math.Abs(b - c);
            double sum = AC + BC;
            Console.Write("Отрезок AC: ");
            Console.WriteLine(AC);
            Console.Write("Отрезок BC: ");
            Console.WriteLine(BC);
            Console.Write("Сумма отрезков AC и BC: ");
            Console.WriteLine(sum);
        }
    }
}
