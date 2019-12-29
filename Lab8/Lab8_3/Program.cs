using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int xa, ya, xb, yb, xc, yc;
            double ab, ac;
            Console.WriteLine("Введите координаты точки A. ");
            Console.Write("Xa:");
            xa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ya:");
            ya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B. ");
            Console.Write("Xb:");
            xb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yb:");
            yb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C. ");
            Console.Write("Xc:");
            xc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yc:");
            yc = Convert.ToInt32(Console.ReadLine());
            ab = Math.Pow(Math.Pow(Math.Abs(xa - xb), 2) + Math.Pow(Math.Abs(ya - yb), 2), 0.5);
            ac = Math.Pow(Math.Pow(Math.Abs(xa - xc), 2) + Math.Pow(Math.Abs(ya - yc), 2), 0.5);
            if (ab > ac)
            {
                Console.WriteLine("C расположена ближе к A " + ab);
            }
            else
            {
                Console.WriteLine("B расположена ближе к A " + ac);
            }
        }
    }
}
