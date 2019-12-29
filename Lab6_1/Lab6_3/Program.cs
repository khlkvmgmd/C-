using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n;
            Console.Write("Введите число K: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Номер дня недели: ");
            Console.WriteLine((n + k - 1) % 7);
        }
    }
}
