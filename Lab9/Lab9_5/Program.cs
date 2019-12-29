using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ABCD, X, Y;
            string E = "", F = "";
            Console.WriteLine("Введите год");
            ABCD = double.Parse(Console.ReadLine());
            ABCD = ABCD - 3;
            X = Math.IEEERemainder(ABCD, 60);
            if (X != 0 && X < 13)
            {
                if (X != 3 && X != 4 && X != 5) E = " зеленой";
                else E = " зеленого";
            }
            if (X > 12 && X < 25)
            {
                if (X != 15 && X != 16 && X != 17) E = " красной";
                else E = " красного";
            }
            if (X > 24 && X < 37)
            {
                if (X != 27 && X != 28 && X != 29) E = " желтой";
                else E = " желтого";
            }
            if (X > 36 && X < 49)
            {
                if (X != 39 && X != 40 && X != 41) E = " белой";
                else E = " белого";
            }
            if (X > 48 && X == 0)
            {
                if (X != 51 && X != 52 && X != 53) E = " черной";
                else E = " черного";
            }
            if (X > 12) Y = Math.IEEERemainder(X, 12);
            else Y = X;
            switch (Y)
            {
                case 1: F = " крысы"; break;
                case 2: F = " коровы"; break;
                case 3: F = " тигра"; break;
                case 4: F = " зайца"; break;
                case 5: F = " дракона"; break;
                case 6: F = " змеи"; break;
                case 7: F = " лошади"; break;
                case 8: F = " овцы"; break;
                case 9: F = " обезьяны"; break;
                case 10: F = " курицы"; break;
                case 11: F = " собаки"; break;
                case 0: F = " свиньи"; break;
            }
            Console.WriteLine("год" + E + F);

        }
    }
}
