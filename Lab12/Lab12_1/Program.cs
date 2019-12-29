using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    class Program
    {
        static double PowerA3(double A, double B)
        {
            B = Math.Pow(A, 3);
            return B;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                double X, Y = 0;
                Console.WriteLine("Введите число");
                X = double.Parse(Console.ReadLine());
                Y = PowerA3(X, Y);
                Console.WriteLine("третья степень числа " + X + " = " + Y);
            }
        }

    }
}
