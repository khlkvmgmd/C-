using System;
namespace Lab1_5CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());
            if (a!=0 && b != 0)
            {
                double sum = Math.Abs(a) + Math.Abs(b);
                double raz = Math.Abs(a) - Math.Abs(b);
                double pro = Math.Abs(a) * Math.Abs(b);
                double cha = Math.Abs(a) / Math.Abs(b);
                Console.Write("Сумма модулей: ");
                Console.WriteLine(sum);
                Console.Write("Разность модулей: ");
                Console.WriteLine(raz);
                Console.Write("Произведение модулей: ");
                Console.WriteLine(pro);
                Console.Write("Частное модулей: ");
                Console.WriteLine(cha);
            }
        }
    }
}
