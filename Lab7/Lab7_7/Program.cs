using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_7
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
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Существует треугольник со сторонами a, b, c");
            }
            else
            {
                Console.WriteLine("Не существует треугольника со сторонами a, b, c");
            }
        }
    }
}
