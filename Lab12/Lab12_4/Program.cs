using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_4
{
    class Program
    {
        static int Quarter(double x, double y, int S)
        {
            if (x > 0 && y > 0) S = 1;
            if (x < 0 && y > 0) S = 2;
            if (x < 0 && y < 0) S = 3;
            if (x > 0 && y < 0) S = 4;
            return S;
        }
        static void Main(string[] args)
        {
            int S = 0;
            string Z;
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Ведите координату х точки " + i);
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату у точки " + i);
                double y = double.Parse(Console.ReadLine());
                S = Quarter(x, y, S);
                if (S == 2) Z = "о ";
                else Z = " ";
                Console.WriteLine("число " + i + " находится = в" + Z + S + " четверти\n");
            }
            Console.ReadLine();
        }

    }
}
