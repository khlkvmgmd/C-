using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a>2 && b <= 3){
                Console.WriteLine("Справедливы неравенства A > 2 и B <= 3");
            }
            else { Console.WriteLine("Несправедливы неравенства A > 2 и B <= 3"); }
        }
    }
}
