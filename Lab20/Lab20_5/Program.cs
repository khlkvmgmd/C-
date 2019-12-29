using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            string s = Console.ReadLine();
            string s0 = Console.ReadLine();
            int len = s0.Length;
            int x = s.Length - len;
            for (int i = 0; i <= x; i++)
            {
                if (s0 == s.Substring(i, len))
                {
                    ++k;
                }
            }
            Console.WriteLine("Количество: " + k);

        }
    }
}
