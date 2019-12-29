using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a * a == b * b + c * c) 
            {
                Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
            }
            else if (b* b == a * a + c * c)
            {
                Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
            }
            else if (c * c == b * b + a * a)
            {
                Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник со сторонами a, b, c НЕ является прямоугольным");
            }
        }
    }
}
