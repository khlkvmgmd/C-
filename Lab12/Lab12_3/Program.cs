using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_3
{
    class Program
    {
        static double RingS(double R1, double R2, double S)
        {
            S = Math.Pow(R1, 2) * Math.PI - Math.Pow(R2, 2) * Math.PI;
            return S;
        }
        static void Main(string[] args)
        {
            for (int X = 1; X < 4; X++)
            {
                Console.WriteLine("Введите внешний радиус " + X + " кольца : ");
                double R1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите внутренний радиус " + X + " кольца : ");
                double R2 = double.Parse(Console.ReadLine());
                double S = RingS(R1, R2, S = 0);
                Console.WriteLine("Площадь " + X + " кольца =" + S + "\n");
            }
            Console.ReadLine();
        }
    }
}
