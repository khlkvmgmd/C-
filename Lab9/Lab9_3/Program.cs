using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int AB, A, B;
            string X = " учебных заданий";
            string Y = " учебное задание";
            string R = "", D = "";
            Console.WriteLine("Введите число от 10 до 40");
            AB = int.Parse(Console.ReadLine());
            if (AB > 10 && AB < 20)
            {
                switch (AB)
                {
                    case 10: Console.WriteLine("десять" + X); break;
                    case 11: Console.WriteLine("одиннадцать" + X); break;
                    case 12: Console.WriteLine("двенадцать" + X); break;
                    case 13: Console.WriteLine("тринадцать" + X); break;
                    case 14: Console.WriteLine("четырнадцать" + X); break;
                    case 15: Console.WriteLine("пятнадцать" + X); break;
                    case 16: Console.WriteLine("шестнадцать" + X); break;
                    case 17: Console.WriteLine("семнадцать" + X); break;
                    case 18: Console.WriteLine("восемнадцать" + X); break;
                    case 19: Console.WriteLine("девятнадцать" + X); break;
                }
            }
            else if (AB > 19)
            {
                A = Math.DivRem(AB, 10, out B);
                switch (A)
                {
                    case 2: R = "двадцать"; break;
                    case 3: R = "тридцать"; break;
                    case 4: R = "сорок"; break;
                }
                switch (B)
                {
                    case 1: D = " одно" + Y; break;
                    case 2: D = " два" + X; break;
                    case 3: D = " три" + X; break;
                    case 4: D = " четыре" + X; break;
                    case 5: D = " пять" + X; break;
                    case 6: D = " шесть" + X; break;
                    case 7: D = " семь" + X; break;
                    case 8: D = " восемь" + X; break;
                    case 9: D = " девять" + X; break;
                    case 0: D = X; break;
                }
                Console.WriteLine(R + D);
            }

        }
    }
}
