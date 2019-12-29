using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, n2;
            Console.Write("Введите число N:");
            n = Convert.ToInt32(Console.ReadLine());
            a = 2 * n - 1;
            n2 = 0;
            for (int i = 1; i <= a; i+=2)
            {
                n2 += i;
                Console.WriteLine(n2);
            } 
        }
    }
}
