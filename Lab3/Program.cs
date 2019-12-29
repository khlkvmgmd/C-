using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double a, b, t;
            Console.Write("Число A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число B: ");
            b = Convert.ToDouble(Console.ReadLine());
            t = a;
            a = b;
            b = t;
            Console.WriteLine("Новое число A: " + a);
            Console.WriteLine("Новое число B: " + b);
        }
    }
}
