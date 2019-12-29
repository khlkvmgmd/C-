using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            Console.Write("А: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * a; //a^2
            a = b * a; //a^3
            a = b * a; //a^5
            c = a * a; //a^10
            a = c * a; //a^15
            Console.WriteLine("A^8" + a);
        }
    }
}