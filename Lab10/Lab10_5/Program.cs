using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int n;
            double b = 0;
            Console.Write("Введите число A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число N:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                b += Math.Pow(a, i) * Math.Pow(-1,i);            }
            Console.WriteLine(b);
        }
    }
}
