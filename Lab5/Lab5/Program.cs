using System;
namespace Lab5
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.Write("Введите размер файла (в байтах): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество полных килобайтов: ");
            Console.WriteLine(a/1024);
        }
    }
}
