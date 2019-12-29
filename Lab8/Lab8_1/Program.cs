using System;
namespace Lab8_1
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                a = 0;
                b = 0;
                Console.WriteLine("A=" + a + ", B=" + b);
            }
            else if (a > b)
            {
                b = a;
                Console.WriteLine("A=" + a + ", B=" + b);
            }
            else
            {
                a = b;
                Console.WriteLine("A=" + a + ", B=" + b);
            }
        }
    }
}