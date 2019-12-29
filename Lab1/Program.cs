using System;

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(Math.Pow(Math.Abs(x2-x1),2)+ Math.Pow(Math.Abs(y2 - y1), 2),0.5));
        }
    }
}