using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] charSeparators = { ' ' };
            string[] result = s.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            int min = result[0].Length;
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i].Length < min)
                {
                    min = result[i].Length;
                }
            }
            Console.WriteLine("Длина минимального слова: " + min);
        }
    }
}
