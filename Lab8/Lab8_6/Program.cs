using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 10)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Четное однозначное число");
                }
                else { Console.WriteLine("Нечетное однозначное число"); }
            }
            else if (a < 100)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Четное двузначное число");
                }
                else { Console.WriteLine("Нечетное двузначное число"); }
            }
            else
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Четное трехзначное число");
                }
                else { Console.WriteLine("Нечетное трехзначное число"); }
            }
        }
    }
}
