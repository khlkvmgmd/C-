using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ABC, A, B, C;
            string D = "", E = "", F = "";
            Console.WriteLine("Введите число в дипазоне 100-999");
            ABC = int.Parse(Console.ReadLine());
            A = Math.DivRem(ABC, 100, out B);
            B = Math.DivRem(B, 10, out C);
            switch (A)
            {
                case 1: D = "сто"; break;
                case 2: D = "двести"; break;
                case 3: D = "тристо"; break;
                case 4: D = "четыресто"; break;
                case 5: D = "пятьсот"; break;
                case 6: D = "шестьсот"; break;
                case 7: D = "семьсот"; break;
                case 8: D = "восемьсот"; break;
                case 9: D = "девятьсот"; break;
            }
            if (B != 1)
            {
                switch (B)
                {
                    case 2: E = " двадцать"; break;
                    case 3: E = " тридцать"; break;
                    case 4: E = " сорок"; break;
                    case 5: E = " пятьдесят"; break;
                    case 6: E = " шестьдесят"; break;
                    case 7: E = " семьдесят"; break;
                    case 8: E = " восемьдесят"; break;
                    case 9: E = " девяносто"; break;
                    case 0: E = " "; break;
                }
                switch (C)
                {
                    case 1: F = " один"; break;
                    case 2: F = " два"; break;
                    case 3: F = " три"; break;
                    case 4: F = " четыре"; break;
                    case 5: F = " пять"; break;
                    case 6: F = " шесть"; break;
                    case 7: F = " семь"; break;
                    case 8: F = " восемь"; break;
                    case 9: F = " девять"; break;
                    case 0: F = " "; break;
                }
            }
            else if (B == 1 && C == 0)
            {
                switch (B)
                {
                    case 1: E = " десять"; break;
                }
                switch (C)
                {
                    case 0: F = " "; break;
                }
            }
            else if (B == 1 && C > 0)
            {
                switch (B)
                {
                    case 1: E = ""; break;
                }
                switch (C)
                {
                    case 1: F = " одиннадцать"; break;
                    case 2: F = " двенадцать"; break;
                    case 3: F = " тринадцать"; break;
                    case 4: F = " четырнадцать"; break;
                    case 5: F = " пятнадцать"; break;
                    case 6: F = " шестнадцать"; break;
                    case 7: F = " семнадцать"; break;
                    case 8: F = " восемнадцать"; break;
                    case 9: F = " девятнадцать"; break;
                }
            }
            Console.WriteLine(D + E + F);

        }
    }
}
