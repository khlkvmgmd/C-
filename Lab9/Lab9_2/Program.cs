using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char K;
            string V, S, Z, U, Q;
            int N;
            Console.WriteLine("Введите символ - исходное направление робота: C-север, З-запад, Ю-юг, В-восток");
            K = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите число - посланную команду роботу: 0 - продолжить движение, 1 - поворот налево, -1 - поворот направо");
            N = int.Parse(Console.ReadLine());
            V = "Восток";
            U = "Юг";
            S = "Север";
            Z = "Запад";
            Q = "Направление робота после полученной команды: ";
            switch (K)
            {
                case 'В':
                    switch (N)
                    {
                        case 0: Console.WriteLine(Q + V); break;
                        case 1: Console.WriteLine(Q + S); break;
                        case -1: Console.WriteLine(Q + U); break;
                        default: Console.WriteLine("Введенные вами данные не корректны для данного кода!"); break;
                    }
                    break;
                case 'С':
                    switch (N)
                    {
                        case 0: Console.WriteLine(Q + S); break;
                        case 1: Console.WriteLine(Q + Z); break;
                        case -1: Console.WriteLine(Q + V); break;
                        default: Console.WriteLine("Введенные вами данные не корректны для данного кода!"); break;
                    }
                    break;
                case 'З':
                    switch (N)
                    {
                        case 0: Console.WriteLine(Q + Z); break;
                        case 1: Console.WriteLine(Q + U); break;
                        case -1: Console.WriteLine(Q + S); break;
                        default: Console.WriteLine("Введенные вами данные не корректны для данного кода!"); break;
                    }
                    break;
                case 'Ю':
                    switch (N)
                    {
                        case 0: Console.WriteLine(Q + U); break;
                        case 1: Console.WriteLine(Q + V); break;
                        case -1: Console.WriteLine(Q + Z); break;
                        default: Console.WriteLine("Введенные вами данные не корректны для данного кода!"); break;
                    }
                    break;
                default: Console.WriteLine("Введенные вами данные не корректны для данного кода!"); break;
            }

        }
    }
}
