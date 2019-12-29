using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine("Предыдущий символ: " + (char)(c - 1) + "\nСледующий символ: " + (char)(c + 1));
        }
    }
}
