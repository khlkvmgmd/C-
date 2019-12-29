using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, f1, f2, f;
            Console.Write("Введите N: ");
            n = Convert.ToInt32(Console.ReadLine());
            k = 2;
            f1 = 1;
            f2 = 1;
            f = 0;
            while (f < n)
            {
                k += 1;
                f = f1 + f2;
                f2 = f1;
                f1 = f;
            }
            Console.WriteLine("Порядковый номер числа - " + k);
        }
    }
}
