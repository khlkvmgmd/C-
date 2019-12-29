using System;
namespace Lab4_СS_
{
    class Program
    {
        static void Main()
        {
            //1
            /*int a;
            double pi = 3.14;
            double l;
            Console.WriteLine("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            if ((a > 0) && (a < 360))
            {
                l = a * (pi / 180);
                Console.WriteLine("l=" + l);
            }
            else { Console.WriteLine("Ошибка"); }*/

            //2
            /*double a;
            double pi = 3.14;
            double l;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if ((a > 0) && (a < (2 * pi)))
            {
                l = a * 180 / pi;
                Console.WriteLine("l=" + l);
            }
            else { Console.WriteLine("Ошибка"); }*/

            //3
            /*double A, x, A1, y, A2;
            Console.WriteLine("Введите A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());
            A1 = A / x;
            A2 = (A * y) / x;
            Console.WriteLine("A1= " + A1);
            Console.WriteLine("A2= " + A2);*/

            //4
            /*double V1, V2, S, S1, T;
            Console.WriteLine("введите V1: ");
            V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите V2: ");
            V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите S: ");
            S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите T: "); 
            T = Convert.ToInt32(Console.ReadLine());
            S1 = S + ((V1 + V2) * T);
            Console.WriteLine("S1=" + S1);*/

            //5
            /*double A, B, x;
            Console.WriteLine("введите A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (A != 0)
            {
                x = (-B) / A;
                Console.WriteLine("x=" + x);
            }
            else { Console.WriteLine("Ошибка "); }*/

            //6
            double A1, A2, B1, B2, C1, C2, x, y;
            Console.WriteLine("введите A1: ");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите A2: "); 
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B1: ");
            B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите B2: ");
            B2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите C1: ");
            C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите C2: ");
            C2 = Convert.ToInt32(Console.ReadLine());
            x = ((C1 * B2) + (C2 * B1)) / ((A1 * B2) - (A2 * B1));
            y = ((C1 * A2) + (C2 * A1)) / ((B1 * A2) - (A1 * B2));
            Console.WriteLine("x= " + x);
            Console.WriteLine("y= " + y);
        }
    }
}