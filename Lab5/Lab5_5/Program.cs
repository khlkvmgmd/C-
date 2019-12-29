using System;
namespace Lab5_5
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("После преобразований: ");
            Console.WriteLine((a - a / 100 * 100) * 10 + a / 100);
        }
    }
}
