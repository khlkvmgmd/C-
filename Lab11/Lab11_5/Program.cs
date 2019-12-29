using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else { b -= a; }
            }
            Console.WriteLine(a);
        }
    }
}
