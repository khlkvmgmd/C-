using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = i; j > 0; j--) 
                {
                    Console.WriteLine(i); 
                }
            }
        }
    }
}
