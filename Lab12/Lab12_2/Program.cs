using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_2
{
    class Program
    {
        static int Sign(int X)
        {
            if (X > 0) X = 1;
            if (X == 0) X = 0;
            if (X < 0) X = -1;
            return X;
        }
        static void Main(string[] args)
        {
            int A, B, S;
            Console.WriteLine("Введите первое число");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            B = int.Parse(Console.ReadLine());
            S = Sign(A) + Sign(B);
            Console.WriteLine("Сумма = " + S);
            Console.ReadLine();
        }
    }
}
