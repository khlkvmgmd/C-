using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 && a < 100 && a % 2 == 0)
            {
                Console.WriteLine("Данное число является четным двузначным");
            }
            else { Console.WriteLine("Данное число НЕ является четным двузначным"); }
        }
    }
}
