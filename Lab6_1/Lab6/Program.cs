using System;
namespace Lab6
{
    class Program
    {
        static void Main()
        {
            int n, m, h;
            Console.Write("Введите число N: ");
            n = Convert.ToInt32(Console.ReadLine());
            h = n / 3600;
            m = (n - h * 3600) / 60;
            Console.Write("Количество секунд, прошедших с начала последней минуты: ");
            Console.WriteLine(n-h*3600-m*60);
        }
    }
}
