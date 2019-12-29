using System;
namespace Lab1_4CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            float b = float.Parse(Console.ReadLine());
            if (a != 0 && b != 0)
            {
                double sum = Math.Pow(a, 2) + Math.Pow(b, 2);
                double raz = Math.Pow(a, 2) - Math.Pow(b, 2);
                double pro = Math.Pow(a, 2) * Math.Pow(b, 2);
                double cha = Math.Pow(a, 2) / Math.Pow(b, 2);
                Console.Write("Сумма квадратов: ");
                Console.WriteLine(sum);
                Console.Write("Разность квадратов: ");
                Console.WriteLine(raz);
                Console.Write("Произведение квадратов: ");
                Console.WriteLine(pro);
                Console.Write("Частное квадратов: ");
                Console.WriteLine(cha);
            }
        }
    }
}
