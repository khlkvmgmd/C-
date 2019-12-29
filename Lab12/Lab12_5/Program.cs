using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_5
{
    class Program
    {
        static double Fact2(double N, double X)
        {
            if (N % 2 == 0) X = 2;
            else X = 1;
            return X;
        }
        static void Main(string[] args)
        {
            double N, S = 1;
            Console.WriteLine("Введите число N");
            N = double.Parse(Console.ReadLine());
            double X = Fact2(N, X = 0);
            for (; X < N || X == N; X += 2)
            {
                S *= X;
            }
            Console.WriteLine("N!! = " + S);
            Console.ReadLine();
        }

    }
}
