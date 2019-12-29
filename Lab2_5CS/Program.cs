using System;
namespace Lab2_5CS
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
            Console.Write("Введите x3: ");
            float x3 = float.Parse(Console.ReadLine());
            Console.Write("Введите y3: ");
            float y3 = float.Parse(Console.ReadLine());
            double s1 = Math.Pow(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2), 0.5);
            double s2 = Math.Pow(Math.Pow(Math.Abs(x2 - x3), 2) + Math.Pow(Math.Abs(y2 - y3), 2), 0.5);
            double s3 = Math.Pow(Math.Pow(Math.Abs(x1 - x3), 2) + Math.Pow(Math.Abs(y1 - y3), 2), 0.5);
            double p = (s1 + s2 + s3) / 2;
            double s = Math.Pow(p * (p - s1) * (p - s2) * (p - s3), 0.5);
            Console.Write("Площадь: ");
            Console.WriteLine(s);
            Console.Write("Периметр: ");
            Console.WriteLine(s1 + s2 + s3);
        }
    }
}
