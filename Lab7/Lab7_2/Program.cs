using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
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
            if (a < b && b < c)
            {
                Console.WriteLine("Справедливо двойное неравенство A < B < C");
            }
            else { Console.WriteLine("Несправедливо двойное неравенство A < B < C"); }
        }
    }
}
