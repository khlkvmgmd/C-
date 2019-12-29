using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int D, N, K; string E = "", F = "", M = ""; 
            Console.WriteLine("Введите номер дня - целое число от 1 до 31"); 
            D = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите номер месяца - целое число от 1 до 12"); 
            N = int.Parse(Console.ReadLine()); 
            switch (N) { 
                case 1: M = " января"; break; 
                case 2: M = " февраля"; break; 
                case 3: M = " марта"; break; 
                case 4: M = " апреля"; break; 
                case 5: M = " мая"; break; 
                case 6: M = " июня"; break; 
                case 7: M = " июля"; break; 
                case 8: M = " августа"; break; 
                case 9: M = " сентября"; break; 
                case 10: M = " октября"; break; 
                case 11: M = " ноября"; break; 
                case 12: M = " декабря"; break; 
                default: Console.WriteLine("Ошибка!"); break; }
            if (D > 10 && D < 20) { 
                switch (D) { 
                    case 11: F = "одиннадцатое"; break; 
                    case 12: F = "двенадцатое"; break; 
                    case 13: F = "тринадцатое"; break; 
                    case 14: F = "четырнадцатое"; break; 
                    case 15: F = "пятнадцатое"; break; 
                    case 16: F = "шестнадцатое"; break; 
                    case 17: F = "семнадцатое"; break; 
                    case 18: F = "восемнадцатое"; break; 
                    case 19: F = "девятнадцатое"; break; } 
                Console.WriteLine(F + M); }
            else if (D > 19 || D < 10)
            {
                if (D > 19) D = Math.DivRem(D, 10, out K); 
                else K = D; 
                if (K == 0) { 
                    switch (D) { 
                        case 1: F = "десятое"; break; 
                        case 2: F = "двадцатое"; break; 
                        case 3: F = "тридцатое"; break; } 
                    switch (K) { 
                        case 0: E = ""; break; } }
                else
                {
                    switch (D) { 
                        case 2: F = "двадцать"; break; 
                        case 3: F = "тридцать"; break; 
                        case 0: F = ""; break; }
                    switch (K)
                    {
                        case 1: E = " первое"; break;
                        case 2: E = " второе"; break;
                        case 3: E = " третье"; break;
                        case 4: E = " четвертое"; break;
                        case 5: E = " пятое"; break;
                        case 6: E = " шестое"; break;
                        case 7: E = " седьмое"; break;
                        case 8: E = " восьмое"; break;

                        case 9: E = " девятое"; break;
                    }
                }
                Console.WriteLine(F + E + M);
            }
        }
    }
}