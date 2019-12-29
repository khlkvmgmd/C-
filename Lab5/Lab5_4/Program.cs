using System;
namespace Lab5_4
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Перестановка цифр : ");
            Console.WriteLine((a - a / 10 * 10) * 10 + a / 10);
        }
    }
}
