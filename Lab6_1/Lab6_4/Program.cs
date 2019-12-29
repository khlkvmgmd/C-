using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, a1, b1;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            c = Convert.ToInt32(Console.ReadLine());
            a1 = a / c;
            b1 = b / c;
            Console.Write("Максимальное количество квадратов: ");
            Console.WriteLine(a1*b1);
            Console.Write("Площадь незанятой части: ");
            Console.WriteLine(a*b-c*a1*c*b1);
        }
    }
}
