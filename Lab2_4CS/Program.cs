using System;
namespace Lab2_4CS
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
            Console.Write("Площадь: ");
            Console.WriteLine(Math.Abs(x1 - x2) * Math.Abs(y1 - y2));
            Console.Write("Периметр: ");
            Console.WriteLine((Math.Abs(x1 - x2) + Math.Abs(y1 - y2)) * 2);
        }
    }
}
