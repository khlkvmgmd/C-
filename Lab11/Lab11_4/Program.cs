using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, s;
            int k = 0;
            Console.Write("P = ");
            p = Convert.ToDouble(Console.ReadLine());
            s = 1000;
            while (s < 1100)
            {
                s += s * (p / 100);
                k += 1;
            }
            Console.WriteLine("Количество месяцев: " + k);
            Console.WriteLine("Итоговый размер вклада: " + s);
        }
    }
}
