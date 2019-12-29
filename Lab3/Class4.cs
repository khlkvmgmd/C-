using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double a, b;
            Console.Write("А: ");
            a = Convert.ToDouble(Console.ReadLine());
            a = a * a;
            b = a * a;
            a = b * b;
            Console.WriteLine("A^8" + a);
        }
    }
}