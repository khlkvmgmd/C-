using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                list[i]=int.Parse(Console.ReadLine());
            }


            for (int i = 0; i <= n/2; i++)
            {
                if (i == n/2 && n % 2 == 0)
                {
                    break;
                }
                Console.Write(list[i] + " ");
                if (i == n / 2 && n % 2 == 1)
                {
                    break;
                }
                Console.Write(list[n - i - 1] + " ");
            }
        }   
    }
}