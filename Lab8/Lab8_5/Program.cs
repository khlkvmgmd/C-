using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Нулевое число");
            }
            else if (a < 0)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Отрицательное четное число");
                }
                else { Console.WriteLine("Отрицательное нечетное число"); }
            }
            else
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Положительное четное число");
                }
                else { Console.WriteLine("Положительное нечетное число"); }
            }
        }
    }
}
