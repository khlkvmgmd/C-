using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            double x, y;
            Console.Write("X: ");
            x = Convert.ToDouble(Console.ReadLine());
            //y = y = 3x^6 − 6x^2 − 7
            y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine("y=" + y);
        }
    }
}

