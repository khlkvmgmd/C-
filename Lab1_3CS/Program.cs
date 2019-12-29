using System;
namespace Lab1_3CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;
            Console.Write("Введите число A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToDouble(Console.ReadLine());
            s = (a + b) / 2;
            Console.Write("Среднее арифметическое равно: ");
            Console.WriteLine(s);
        }
    }
}
