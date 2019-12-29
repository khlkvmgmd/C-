using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 100 > 0){
                Console.Write("Номер столетия: ");
                Console.WriteLine(a / 100 + 1);
            }
            else { Console.Write("Номер столетия: "); 
                Console.WriteLine(a / 100 ); }
        }
    }
}
