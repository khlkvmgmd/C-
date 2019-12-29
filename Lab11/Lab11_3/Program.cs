using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, a;
            Console.Write("Введите N: ");
            n = Convert.ToInt32(Console.ReadLine());
            k = 1;
            a = 1;
            while (a < n)
            {
                k += 1;
                a += k;
            }
            Console.WriteLine("Наименьшее число K: " + k);
        }
    }
}
