using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            y = Convert.ToInt32(Console.ReadLine());
            if (y > 0) 
            {
                if (x > 0)
                {
                    Console.WriteLine("I четверть");
                }
                else { Console.WriteLine("II четверть"); }
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine("IV четверть");
                }
                else { Console.WriteLine("III четверть"); }
            }

        }
    }
}
