using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = Convert.ToChar(Console.ReadLine());
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    Console.Write(s[i]);
                    Console.Write((char)c);
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
