using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.Write("Введите число K: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Номер дня недели: ");
            Console.WriteLine(k - k / 7 * 7);
        }
    }
}
