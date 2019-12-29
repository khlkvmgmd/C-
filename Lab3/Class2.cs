using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double a, b, c, t1, t2;
            Console.Write("Число A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Число C: ");
            c = Convert.ToDouble(Console.ReadLine());
            t1 = a;
            a = b;
            b = c;
            c = t1;
            Console.WriteLine("Новое число A: " + a);
            Console.WriteLine("Новое число B: " + b);
            Console.WriteLine("Новое число C: " + c);
        }
    }
}
