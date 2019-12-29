using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.Write("Введите A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (a > b) 
            {
                a -= b;
            } 
            Console.WriteLine(a);
        }
    }
}
