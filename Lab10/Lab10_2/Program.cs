using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double b, a = 1.1;
            b = 1.2;
            Console.Write("Введите число N:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                a *= b;
                b += 0.1;
            }
            Console.WriteLine(a);
        }
    }
}
