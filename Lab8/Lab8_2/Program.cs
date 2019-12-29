using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                if (b >= c)
                {
                    sum = a + b;
                }
                else { sum = a + c; }
            }
            else
            {
                if (a>=c){
                    sum = a + b;
                }
                else { sum = b + c; }
            }
            Console.WriteLine("Сумма наибольших чисел равна " + sum);
        }
    }
}
